using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

using System.Threading;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections;


namespace POI
{
    public class Client
    {

        public Boolean mIsConnected { get; set; }
        public Boolean mIsThreadRunning { get; set; }
        public String mName { get; set; }
        public String mMail { get; set; }
        public String mPassword { get; set; }
        public String mImg { get; set; }
        public String mEstado { get; set; }
        public IPAddress mIp;
        public string encriptado { get; set; }
        public Socket mSocket;
        Action<String> ContactsCallback;
        Action<String> WebcamCallback;
        Action<String, String> WebcamCallbackEstablish;
        Action<String, String> FileCallbackAccept;
        Action<String, String> ConversacionCallback;
        Action<String, String> MessageCallback;
        Action<String, String> GroupMessageCallback;
        Action<String, String, String> MuroCallback;
        public Client()
        {
            mSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            mIsConnected = false;

        }
        public Client(string mail)
        {
            mMail = mail;
        }
        public Client(string name, string mail, string pass, string img, string estado)
        {
            mName = name;
            mMail = mail;
            mPassword = pass;
            mImg = img;
            mEstado = estado;
        }

        public Client(Socket socket)
        {
            mSocket = socket;
            mIsConnected = true;
        }

        public void connect()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(Server.ADDRESS), Server.PORT);
            try
            {
                mSocket.Connect(endPoint);
                mIsConnected = true;
            }
            catch (Exception e)
            {
                mIsConnected = false;
                Console.WriteLine("ERROR: CONECTANDO CLIENTE" + e.ToString());
            }
        }
        public void listenPrincipal(Action<String> mContactsCallback)
        {
            ContactsCallback = mContactsCallback;
            mIsThreadRunning = true;
            new Thread(() =>
            {
                while (mIsThreadRunning)
                {
                    byte[] bufferCmd = new byte[1024];
                    mSocket.Receive(bufferCmd);

                    bufferCmd = Utils.cleanBuffer(bufferCmd);
                    String cmd = Encoding.Default.GetString(bufferCmd);
                    if (cmd.Contains("<CambiarLista>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingMessage>", "<size>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);

                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);

                        String message = Encoding.Default.GetString(bufferMessage);
                        //MsgCallback.Invoke(message);
                    }
                    if (cmd.Contains("IncomingClient"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingClient>", "<size>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);

                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);

                        String name = Encoding.Default.GetString(bufferMessage);
                        //ComboCallback.Invoke(name);
                    }
                }
            }).Start();
        }
        public void listening(Action<String, String> mConversacionCallback, Action<String, String> mMessageCallback, Action<String, String, String> mMuroCallback, Action<String> mOnWebcamCallback, Action<String, String> mOnWebcamCallbackEstablish, Action<String, String> mFileCallbackAccept, Action<String, String> mGroupMessageCallback)
        {
            ConversacionCallback = mConversacionCallback;
            FileCallbackAccept = mFileCallbackAccept;
            WebcamCallback = mOnWebcamCallback;
            MessageCallback = mMessageCallback;
            GroupMessageCallback = mGroupMessageCallback;
            MuroCallback = mMuroCallback;
            WebcamCallbackEstablish = mOnWebcamCallbackEstablish;
            mIsThreadRunning = true;
            new Thread(() =>
            {
                while (mIsThreadRunning)
                {
                    byte[] bufferCmd = new byte[1024];
                    mSocket.Receive(bufferCmd);
                    bufferCmd = Utils.cleanBuffer(bufferCmd);
                    String cmd = Encoding.Default.GetString(bufferCmd);
                    #region coment
                    /*
                    if (cmd.Contains("IncomingMessage"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingMessage>", "<size>","<to>","<from>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);
                        string para = sizeSplit[1];
                        string desde = sizeSplit[2];
                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);

                        String message = Encoding.Default.GetString(bufferMessage);
                        MsgCallback.Invoke(message);
                    }
                    if (cmd.Contains("IncomingClient"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingClient>", "<size>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);

                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);

                        String name = Encoding.Default.GetString(bufferMessage);
                        ComboCallback.Invoke(name);
                    }*/
                    #endregion

                    if (cmd.Contains("<IncomingChat>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingChat>", "<from>", "<to>", "<size>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[2]);
                        string name1 = sizeSplit[0];
                        string name2 = sizeSplit[1];
                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);
                        String conversacion = Encoding.Default.GetString(bufferMessage);
                        ConversacionCallback.Invoke(name2, conversacion);
                    }
                    if (cmd.Contains("<IncomingMessage>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<IncomingMessage>", "<size>", "<name>", "<message>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);
                        string name = sizeSplit[1];
                        string message = sizeSplit[2];
                        //byte[] bufferMessage = new byte[size];
                        //mSocket.Receive(bufferMessage);
                        //String message = Encoding.Default.GetString(bufferMessage);
                        MessageCallback.Invoke(message, name);
                    }
                    if (cmd.Contains("<ActualizaMuro>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<ActualizaMuro>", "<muro>", "<usuario>", "<size>", "<mensaje>" }, StringSplitOptions.RemoveEmptyEntries);
                        //int size = Int32.Parse(sizeSplit[5]);
                        string muro = sizeSplit[0];
                        string usuario = sizeSplit[1];
                        string mensaje = sizeSplit[2];
                        //byte[] bufferMessage = new byte[size];
                        //mSocket.Receive(bufferMessage);
                        //String message = Encoding.Default.GetString(bufferMessage);
                        MuroCallback.Invoke(muro, usuario, mensaje);
                        //MuroCallback.Invoke(muro, usuario, muro);
                    }
                    if (cmd.Contains("<WebcamRequest>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<WebcamRequest>", "<de>" }, StringSplitOptions.RemoveEmptyEntries);
                        //int size = Int32.Parse(sizeSplit[5]);
                        string de = sizeSplit[0];
                        //byte[] bufferMessage = new byte[size];
                        //mSocket.Receive(bufferMessage);
                        //String message = Encoding.Default.GetString(bufferMessage);
                        WebcamCallback.Invoke(de);
                        //MuroCallback.Invoke(muro, usuario, muro);
                    }
                    if (cmd.Contains("<RecibeArchivo>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<RecibeArchivo>", "<path>", "<from>" }, StringSplitOptions.RemoveEmptyEntries);
                        string path = sizeSplit[0];
                        string nombre = sizeSplit[1];
                        //MuroCallback.Invoke(muro, usuario, muro);
                        FileCallbackAccept(path, nombre);
                    }
                    if (cmd.Contains("<ReceiveFile>"))
                    {
                        String[] sizeSplit = cmd.Split(new String[] { "<ReceiveFile>", "<size>", "<nombre>" }, StringSplitOptions.RemoveEmptyEntries);
                        int size = Int32.Parse(sizeSplit[0]);
                        string nombreArchivo = sizeSplit[1];
                        byte[] bufferMessage = new byte[size];
                        mSocket.Receive(bufferMessage);
                        String newpath = "C:\\Users\\Alejandro\\Desktop\\POI\\FClient\\bin\\Debug\\Descargas\\" + nombreArchivo;
                        File.WriteAllBytes(newpath, bufferMessage);
                    }

                }
            }).Start();
        }

        public void sendMessageToClient(String msg, String clientName)
        {
            //enviamos el comando y los parametros para que el servidor prepara la recepcion y envio del mensaje
            String sendCommand = "<SendMessage>";
            sendCommand += "<size>";
            sendCommand += Encoding.Default.GetBytes(msg).Length;
            sendCommand += "<size>";
            sendCommand += "<to>";
            sendCommand += clientName;
            sendCommand += "<to><message>" +
            msg + "<message>";
            sendCommand += "<SendMessage>";
            sendStringMsg(sendCommand);
        }

        public void sendGroupMessage(String msg, String groupName)
        {
            //enviamos el comando y los parametros para que el servidor prepara la recepcion y envio del mensaje
            String sendCommand = "<SendGroupMessage>";
            sendCommand += "<size>";
            sendCommand += Encoding.Default.GetBytes(msg).Length;
            sendCommand += "<size>";
            sendCommand += "<group>";
            sendCommand += groupName;
            sendCommand += "<group><message>" +
            msg + "<message>";
            sendCommand += "<SendGroupMessage>";
            sendStringMsg(sendCommand);
        }

        public void cargaMuro(String muro)
        {
            String sendCommand = "<CargaMuro>" +
            muro +
            "<CargaMuro>";
            sendStringMsg(sendCommand);
        }
        public void subeArchivo(String para, byte[] buffer, String path, long size)
        {
            String sendCommand = "<MandaArchivo><path>" + path + "<path><size>" + size + "<size><nombre>" + para + "<nombre><MandaArchivo>";
            sendStringMsg(sendCommand);
            mSocket.Send(buffer);
        }
        public void actualizaMuro(String muro, String nombre, String Publicacion)
        {
            String sendCommand = "<EscribeMuro><muro>" +
            muro +
            "<muro><nombre>" +
            nombre + "<nombre><publicacion>" +
            Publicacion +
            "<publicacion><EscribeMuro>";
            sendStringMsg(sendCommand);
        }
        public void webCamRequest(String para)
        {
            String sendCommand = "<WebcamRequest><nombre>" +
            para + "<nombre>" +
            "<WebcamRequest>";
            sendStringMsg(sendCommand);
        }
        public void webCamAccept(String para, String de)
        {
            String sendCommand = "<WebcamAccept><de>" +
            de + "<de>" + "<para>" +
            para + "<para>" +
            "<WebcamAccept>";
            sendStringMsg(sendCommand);
        }
        public void descargaArchivo(String ruta)
        {
            String sendCommand = "<FileDownload><path>" +
            ruta + "<path>" +
            "<FileDownload>";
            sendStringMsg(sendCommand);
        }
        public void loadChat(String desdeCliente, String paraCliente)
        {
            String sendCommand = "<Chatprivado>";
            sendCommand += "<from>";
            sendCommand += desdeCliente;
            sendCommand += "<from>";
            sendCommand += "<to>";
            sendCommand += paraCliente;
            sendCommand += "<to>";
            sendCommand += "<Chatprivado>";
            //enviamos el comando
            sendStringMsg(sendCommand);
        }

        public void loadChatGrupal(String desdeCliente, String paraCliente, ArrayList integrantes)
        {
            String sendCommand = "<Chatgrupal>";
            sendCommand += "<from>";
            sendCommand += desdeCliente;
            sendCommand += "<from>";
            sendCommand += "<to>";
            sendCommand += paraCliente;
            sendCommand += "<to>";
            sendCommand += "<Chatgrupal>";
            //enviamos el comando
            sendStringMsg(sendCommand);
        }

        public void sendStringMsg(String msg)
        {
            // Convierte un String en arreglo de byte
            byte[] buffer = Encoding.Default.GetBytes(msg);
            mSocket.Send(buffer);
        }
    }
}
