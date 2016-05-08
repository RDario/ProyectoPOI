using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using POI;  
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using Voice;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Net.Sockets;
namespace FClient
{
    public partial class chat : Form
    {
        Client mClient = new Client();
        Client otherClient = new Client();
        delegate void OnMessageDelegate(String msg);
        delegate void comienzaWebcamDelegate(String msg);
        delegate void onConversacionDelegate(String msg);
        delegate void onFileDelegate(String msg);
        delegate void onClip(object lbl);

       
        Thread Sender; // thread for sending images
        Thread Receiver; // thread for receiving images
        bool Closing = false; // true if form is to be quit
        byte[] ClosingBytes; // byte coding of this message
        ASCIIEncoding ByteConverter = new ASCIIEncoding(); // object to convert strings to byte arrays and other way


        //=========================================
        //-------------VideoLlamada------------------
        private Thread Recibir;
        private bool isAliveThread = false;
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private bool haystreaming = false;
        private VideoCaptureDevice FuenteDeVideo;
        private Bitmap imgstream;
        private bool startstream = false;
        private IPEndPoint ipepp;
        private UdpClient socketrecibevideo;
        private System.Drawing.Image imgchat;
        public IPAddress ipa = IPAddress.Parse("0.0.0.0");
        //Audio
        private Socket r;
        private UdpClient socketrecibeaudio;
        private Thread t;
        private bool connected = false;
        private WaveOutPlayer m_Player;
        private WaveInRecorder m_Recorder;
        private FifoStream m_Fifo = new FifoStream();

        private byte[] m_PlayBuffer;
        private byte[] m_RecBuffer;
        //------------------------------------------
        public void comienzaWebcam(String ip)
        {
            if (InvokeRequired)
            {
                comienzaWebcamDelegate d = new comienzaWebcamDelegate(comienzaWebcam);
                this.Invoke(d, new object[] { ip });
            }
            else
            {
                ipa = IPAddress.Parse(ip);
                this.Size = new System.Drawing.Size(660, 405);
                BuscarDispositivos();
                Recibir = new Thread(new ThreadStart(GetStream));
                Recibir.Start();
                ipepp = new IPEndPoint(ipa, 12446);
                socketrecibevideo = new UdpClient(12446);
                socketrecibeaudio = new UdpClient(6000);
                r = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                t = new Thread(new ThreadStart(Voice_In));
                t.Start();
                haystreaming = true;
            }
        }
        //cuando (bool) Closing sea true se cierra el hilo de la webcam
        
        public void onMessageCallback(String msg)
        {
            if (rTBChat1.InvokeRequired)
            {
                OnMessageDelegate callback = new OnMessageDelegate(onMessageCallback);
                this.Invoke(callback, new object[] { msg });
            }
            else
            {
                rTBChat1.AppendText(msg + "\n");

                //LAB EMOTICONES
                //si rTBChat1 contiene emoticones, reemplazalos por los hash (iconos)


            }
        }

        private void SetToClipboard(object text)
        {
            if (rTBChat1.InvokeRequired)
            {
                onClip callback = new onClip(SetToClipboard);
                this.Invoke(callback, new object[] { text });
            }
            else
            {
                System.Windows.Forms.Clipboard.SetDataObject(text);
            }
        }
        public void onConversacionCallback(String msg)
        {
            if (rTBChat1.InvokeRequired)
            {
                onConversacionDelegate callback = new onConversacionDelegate(onConversacionCallback);
                this.Invoke(callback, new object[] { msg });
            }
            else
            {
                this.rTBChat1.Text = msg + "\n";
                    
                //emoticones
            }
        }
        public chat()
        {
            InitializeComponent();
        }
        public chat(Client mmClient, Client ootherClient)
        {
            InitializeComponent();
            mClient = mmClient;

            otherClient = ootherClient;
            lblNombre.Text = otherClient.mName;
            lblEstado.Text = otherClient.mEstado;
            pbChat.ImageLocation = otherClient.mImg;
            //mClient.loadChat(mClient.mName, otherClient.mName); //cargamos las conversaciones guardadas en txt.
            optionList1.Visible = true;
            BuscarDispositivos();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mClient.sendMessageToClient(txtMessage.Text, otherClient.mName);
            txtMessage.Text = "";
        }

        private void optionList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textito;
            if (optionList1.Items[0].Selected == true)
            {
                textito = optionList1.Items[0].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[1].Selected == true)
            {
                textito = optionList1.Items[1].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[2].Selected == true)
            {
                textito = optionList1.Items[2].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[3].Selected == true)
            {
                textito = optionList1.Items[3].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[4].Selected == true)
            {
                textito = optionList1.Items[4].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[5].Selected == true)
            {
                textito = optionList1.Items[5].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[6].Selected == true)
            {
                textito = optionList1.Items[6].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[7].Selected == true)
            {
                textito = optionList1.Items[7].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[8].Selected == true)
            {
                textito = optionList1.Items[8].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[9].Selected == true)
            {
                textito = optionList1.Items[9].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[10].Selected == true)
            {
                textito = optionList1.Items[10].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[11].Selected == true)
            {
                textito = optionList1.Items[11].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[12].Selected == true)
            {
                textito = optionList1.Items[12].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[13].Selected == true)
            {
                textito = optionList1.Items[13].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[14].Selected == true)
            {
                textito = optionList1.Items[14].Text;
                txtMessage.AppendText(textito);
            }

            if (optionList1.Items[15].Selected == true)
            {
                textito = optionList1.Items[15].Text;
                txtMessage.AppendText(textito);
            }
        }

        private void chat_Load(object sender, EventArgs e)
        {

        }

        private void chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            // dispose webcam at closing
            if (FuenteDeVideo != null && FuenteDeVideo.IsRunning)
            {
                FuenteDeVideo.SignalToStop();
                FuenteDeVideo = null;
            }

            Closing = true;

            Thread.Sleep(3000);

            if (Sender != null && Sender.IsAlive)
                Sender.Abort();

            if (Receiver != null && Receiver.IsAlive)
                Receiver.Abort();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Filter to only text files
            openFileDialog1.Filter = "All Files (*.*)|*.*";
            //No initial file selected
            openFileDialog1.FileName = String.Empty;

            //Open file dialog and store the returned value
            DialogResult result = openFileDialog1.ShowDialog();

            //If Open Button was pressed
            if (result == DialogResult.OK)
            {

                Stream fs = openFileDialog1.OpenFile();
                System.IO.MemoryStream data = new System.IO.MemoryStream();

                fs.CopyTo(data);
                data.Seek(0, SeekOrigin.Begin);
                byte[] buf = new byte[data.Length];
                data.Read(buf, 0, buf.Length);
                mClient.subeArchivo(this.Text,buf,Path.GetFileName(openFileDialog1.FileName),data.Length);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            mStream.Seek(0, SeekOrigin.Begin);
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;

        }

        private void cbxDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new AForge.Video.NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivos...";
                    btnIniciar.Text = "Detener";
                    cbxDispositivos.Enabled = false;
                    tim_stream.Enabled = true;
                    
                }
                else
                    Estado.Text = "Error:No se encuentra el Dispositivo";
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = "Dispositivo Detenido..";
                    btnIniciar.Text = "Iniciar";
                    cbxDispositivos.Enabled = true;
                }
            }
            mClient.webCamRequest(this.Text);
        }

        
        public void SendStream(System.Drawing.Image img)
        {
            /*if (cb_encrypt.Checked == true)
            {
                UdpClient tempSocket = new UdpClient();
                Byte[] sendBytes = imageToByteArray(img);
                IPEndPoint tempipep = new IPEndPoint(ipa, 12446);
                tempSocket.Send(sendBytes, sendBytes.Length, tempipep);
            }
            else
            {*/
            UdpClient tempSocket = new UdpClient();
            Byte[] sendBytes = imageToByteArray(img);
            IPEndPoint tempipep = new IPEndPoint(ipa, 12446);

            tempSocket.Send(sendBytes, sendBytes.Length, tempipep);
            //}
        }
        public void GetStream()
        {
            isAliveThread = true;
            while (isAliveThread)
            {
                while (startstream)     //SI HAY UN STREAMING, RECIBE LA IMAGEN COMO ARREGLO DE BYTES
                {

                    Byte[] receiveBytes = socketrecibevideo.Receive(ref ipepp);
                    ReceiveStream(receiveBytes);

                }
            }
            isAliveThread = false;
        }       //FUNCIÓN DEL HILO QUE CHECA SI HAY UN STREAMING ACTIVO
        public void ReceiveStream(Byte[] byteImg)
        {
            if (haystreaming == true)
            {
                imgchat = byteArrayToImage(byteImg);
                webcam2.SizeMode = PictureBoxSizeMode.StretchImage;
                webcam2.SizeMode = PictureBoxSizeMode.StretchImage;
                webcam2.SizeMode = PictureBoxSizeMode.StretchImage;
                webcam2.Image = imgchat;
            }
        }           //RECIBE EL ARREGLO DE BYTES Y LO CONVIERTE A IMAGEN, LA CUAL SE PASA AL PICTUREBOX QUE MUESTRA AL OTRO USUARIO

        public Byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            if(imageIn!=null)
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }       //CONVIERTE LA IMAGEN A BYTE[]
        public System.Drawing.Image byteArrayToImage(Byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            //AForge.Imaging.Image returnImage = AForge.Imaging.Image.FromStream(ms);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }   //CONVIERTE EL BYTE[] A IMAGEN
        private void Voice_In()
        {
            byte[] br;
            IPEndPoint tempipep = new IPEndPoint(ipa, 6000);

            //r.Bind(tempipep);
            while (true)
            {
                br = new byte[16384];
                br = socketrecibeaudio.Receive(ref ipepp);
                //socketrecibeaudio.Receive(br);
                m_Fifo.Write(br, 0, br.Length);
            }
        }
        #region Voice_Out()

        private void Voice_Out(IntPtr data, int size)
        {
            UdpClient tempSocket = new UdpClient();
            IPEndPoint tempipep = new IPEndPoint(ipa, 6000);

            //for Recorder
            if (m_RecBuffer == null || m_RecBuffer.Length < size)
                m_RecBuffer = new byte[size];
            System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size);
            //Microphone ==> data ==> m_RecBuffer ==> m_Fifo
            tempSocket.Send(m_RecBuffer, m_RecBuffer.Length, tempipep);
            //r.SendTo(m_RecBuffer, tempipep);
        }

        #endregion

        private void Start()
        {
            Stop();
            try
            {
                WaveFormat fmt = new WaveFormat(44100, 16, 2);
                m_Player = new WaveOutPlayer(-1, fmt, 16384, 3, new BufferFillEventHandler(Filler));
                m_Recorder = new WaveInRecorder(-1, fmt, 16384, 3, new BufferDoneEventHandler(Voice_Out));
            }
            catch
            {
                Stop();
                throw;
            }
        }

        private void Stop()
        {
            if (m_Player != null)
                try
                {
                    m_Player.Dispose();
                }
                finally
                {
                    m_Player = null;
                }
            if (m_Recorder != null)
                try
                {
                    m_Recorder.Dispose();
                }
                finally
                {
                    m_Recorder = null;
                }
            m_Fifo.Flush(); // clear all pending data
        }

        private void Filler(IntPtr data, int size)
        {
            if (m_PlayBuffer == null || m_PlayBuffer.Length < size)
                m_PlayBuffer = new byte[size];
            if (m_Fifo.Length >= size)
                m_Fifo.Read(m_PlayBuffer, 0, size);
            else
                for (int i = 0; i < m_PlayBuffer.Length; i++)
                    m_PlayBuffer[i] = 0;
            System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
            // m_Fifo ==> m_PlayBuffer==> data ==> Speakers
        }

        private void tim_stream_Tick(object sender, EventArgs e)
        {
            if (haystreaming == true)
            {
                startstream = true;
                SendStream(webcam1.Image);
                Start();
            }
            else
            {
                startstream = false;
            }
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }
        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            webcam1.SizeMode = PictureBoxSizeMode.StretchImage;
            webcam1.Image = Imagen;
            imgstream = Imagen;
        }
        private Image ReadImage(NetworkStream stream)
        {
            Image Result;
            int BytesRead;

            // read the first 20 bytes of the stream, since they encode the size of the image
            byte[] ImageSize = new byte[20];
            BytesRead = stream.Read(ImageSize, 0, 20);

            /* if only 12 bytes can be read and they contain the closing string, a termination is requested */
            if (BytesRead == 12)
            {
                if (ByteConverter.GetString(ImageSize, 0, 12) == "FORM#CLOSING")
                {
                    Closing = true;
                    return null;
                }
            }

            byte[] ErrorBuffer = new byte[100000000];

            ASCIIEncoding Decoder = new ASCIIEncoding();
            string ImageSizeString = Decoder.GetString(ImageSize).Replace("x", "");

            int TestSize;

            if (!int.TryParse(ImageSizeString, out TestSize))
            {
                stream.Read(ErrorBuffer, 0, ErrorBuffer.Length);
                return null;
            }

            byte[] ImageFile = new byte[int.Parse(ImageSizeString)];

            stream.Read(ImageFile, 0, ImageFile.Length);

            MemoryStream temps = new MemoryStream();

            try
            {
                temps.Write(ImageFile, 0, ImageFile.Length);
                Result = Image.FromStream(temps);
                return Result;
            }
            catch
            {
                return null;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pbCorreo_Click(object sender, EventArgs e)
        {
            Correo form = new Correo(otherClient,mClient);
            form.Name = "Principal";
            form.Show();
        }
        
        
    }
}