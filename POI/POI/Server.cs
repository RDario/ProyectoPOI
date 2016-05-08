using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Librerias de .Net para el uso de Sockets
using System.Net;
using System.Net.Sockets;
// Librerias de .Net para el manejo de Hilos
using System.Threading;
using System.IO;
namespace POI
{
    public class Server
    {
        public static int PORT = 12345;
        public static String ADDRESS = "192.168.1.7";
        //
        private Socket mSocket { get; set; }
        private IPEndPoint mEndPoint { get; set; }
        //
        public Boolean mIsThreadRunning { get; set; }
        //
        public List<Client> mClients { get; set; } //aqui se agrega una lista de clientes conectados
        Action<Client> mOnClientConnectedCallback;//agregado en la clase de hilos
        public Server(Action<Client> OnClientConnectedCallback)//agregado en la clase de hilos
        {
            mOnClientConnectedCallback = OnClientConnectedCallback;//agregado en la clase de hilos
            mIsThreadRunning = false;
            // Version de ip, Tipo de Socket, Protocolo
            mSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // EndPoint *
            mEndPoint = new IPEndPoint(IPAddress.Parse(ADDRESS), PORT);
            mClients = new List<Client>();
            listen();
        }
        public void listen()
        {
            mIsThreadRunning = true;
            mSocket.Bind(mEndPoint);
            mSocket.Listen(50);

            new Thread(() =>
            {
                while (mIsThreadRunning)
                {
                    try
                    {
                        Socket clientSocket = mSocket.Accept();//recibe un socket valido y se lo pasa a cliente
                        Client client = new Client(clientSocket);
                        IPEndPoint remoteIpEndPoint = clientSocket.RemoteEndPoint as IPEndPoint;
                        IPEndPoint localIpEndPoint = clientSocket.LocalEndPoint as IPEndPoint;
                        IPEndPoint remoteIpEndPoint1 = clientSocket.RemoteEndPoint as IPEndPoint;
                        IPAddress mi_ip = remoteIpEndPoint1.Address;
                        IPAddress su_ip = remoteIpEndPoint1.Address;
                        // Iniciamos nuevo thread para recibir el nombre del cliente
                        new Thread(() =>
                        {
                            try
                            {
                                
                                //byte[] bufEnc = new byte[1024];
                                byte[] buffer = new byte[1024];
                                //client.mSocket.Receive(bufEnc);
                                client.mSocket.Receive(buffer);
                                // Limpiamos el buffer de basura o bytes nulos
                                //bufEnc = Utils.cleanBuffer(bufEnc);
                                buffer = Utils.cleanBuffer(buffer);
                                //obtenemos un "encriptado" o "noencriptado" para saber si esta encriptado
                                //string encripted = Encoding.Default.GetString(bufEnc);
                                // Obtenemos el String de los bytes
                                String clientInfo = Encoding.Default.GetString(buffer);
                                //si esta encriptado, desencriptamos el texto
                                //if(encripted=="encriptado")
                                //clientInfo = Utils.desencriptar(clientInfo);
                                // Asignamos el nombre del cliente;
                                string[] infoDividida = clientInfo.Split(new String[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                                            
                                client.mName = infoDividida[0];
                                client.mMail = infoDividida[1];
                                client.mPassword = infoDividida[2];
                                client.mImg = infoDividida[3];
                                client.mIp = mi_ip;
                                client.mEstado = "Disponible";
                                // Agregamos el cliente a la lista de clientes para en un futuro poder acceder a el sin perder la referencia al socket
                                mClients.Add(client);
                                /*foreach (Client c in mClients) //llenar combobox
                                {
                                    if (c.mName != client.mName)
                                    {
                                        String cmd = "<IncomingClient><size>" + Encoding.Default.GetBytes(client.mName).Length + "<size><IncomingClient>";
                                        c.sendStringMsg(cmd);
                                        c.sendStringMsg(client.mName);
                                    }
                                }
                                mOnClientConnectedCallback.Invoke(client);//agregado en la clase de hilos
                                foreach (Client c in mClients) //llenar combobox
                                {
                                    if (c.mName != client.mName)
                                    {
                                        String cmd = "<IncomingClient><size>" + Encoding.Default.GetBytes(client.mName).Length + "<size><IncomingClient>";
                                        c.sendStringMsg(cmd);
                                        c.sendStringMsg(client.mName);
                                    }
                                }

                                foreach (Client c in mClients)
                                {
                                    if (c.mName != client.mName)
                                    {
                                        String cmd = "<IncomingClient><size>" + Encoding.Default.GetBytes(c.mName).Length + "<size><IncomingClient>";
                                        client.sendStringMsg(cmd); 
                                        client.sendStringMsg(c.mName);
                                    }
                                }*/
                                new Thread(() =>
                                {
                                    while (mIsThreadRunning)
                                    {
                                        //Recibir el comando para preparar al servidor
                                        buffer = new byte[1024];
                                        //bufEnc = new byte[1024];
                                        //client.mSocket.Receive(bufEnc);
                                        client.mSocket.Receive(buffer);
                                        buffer = Utils.cleanBuffer(buffer);
                                        //bufEnc = Utils.cleanBuffer(bufEnc);
                                        //encripted = Encoding.Default.GetString(bufEnc);
                                        String command = Encoding.Default.GetString(buffer);
                                        //if (encripted == "encriptado")
                                            //command = Utils.desencriptar(command);

                                        if (command.Contains("<SendMessage>"))
                                        {
                                            // Original
                                            // <SendMessage><size>1828<size><to>Javier<to> <SendMessage>
                                            String[] mainSplit = command.Split(new String[] { "<SendMessage>" },StringSplitOptions.RemoveEmptyEntries);
                                            //<size>1828<size><to>JAvier<to>
                                            string[] contentSplit = mainSplit[0].Split(new String[] { "<size>","<to>","<message>" }, StringSplitOptions.RemoveEmptyEntries);
                                            //tamaño del mensaje
                                            int receiveSize = Int32.Parse(contentSplit[0]);
                                            //Para quien va el mensaje
                                            String toClientname = contentSplit[1];

                                           // buffer = new byte[receiveSize];
                                           // client.mSocket.Receive(buffer);
                                            //obtenemos el mensaje
                                            //String message = Encoding.Default.GetString(buffer);
                                            String message = contentSplit[2];
                                            String message1 = client.mName + ": " + message;


                                            //ESCRIBIR SOBRE TXT
                                            StreamWriter escrito;
                                            if (File.Exists("Conversaciones/" + toClientname + "-" + client.mName + ".txt"))
                                                escrito = File.AppendText("Conversaciones/" + toClientname + "-" + client.mName + ".txt");
                                            else
                                                escrito = File.AppendText("Conversaciones/" + client.mName + "-" + toClientname + ".txt");

                                            String contenido = "\r\n"+message1;
                                            escrito.Write(contenido);
                                            escrito.Flush();
                                            escrito.Close();
                                            //ESCRIBIR SOBRE TXT
                                            int aux = receiveSize + Encoding.Default.GetBytes(client.mName).Length;
                                            aux += 2;

                                            foreach(Client c in mClients){
                                                if (c.mName == toClientname && c.mEstado != "desconectado")
                                                {
                                                    String cmd = "<IncomingMessage><size>" + aux + "<size><name>"
                                                        + client.mName + "<name><message>" + message1 + "<message><IncomingMessage>";
                                                    c.sendStringMsg(cmd);
                                                }
                                                else
                                                if (c.mName == client.mName)
                                                {
                                                    String cmd = "<IncomingMessage><size>" + aux + "<size><name>"
                                                        + toClientname + "<name><message>" + message1 + "<message><IncomingMessage>";
                                                    c.sendStringMsg(cmd);
                                                }
                                            }
                                            
                                        }
                                        else if (command.Contains("Chatprivado"))
                                        {
                                            string path;
                                            String[] mainSplit = command.Split(new String[] { "<Chatprivado>" }, StringSplitOptions.RemoveEmptyEntries);
                                            //<size>1828<size><to>JAvier<to>
                                            string[] contentSplit = mainSplit[0].Split(new String[] { "<from>", "<to>" }, StringSplitOptions.RemoveEmptyEntries);
                                            //tamaño del mensaje
                                            String fromClientname = contentSplit[0];
                                            //Para quien va el mensaje
                                            String toClientname = contentSplit[1];
                                            foreach (Client c in mClients)
                                            {
                                                if (c.mName==fromClientname||c.mName==toClientname)
                                                {
                                                    if (File.Exists("Conversaciones/" + fromClientname + "-" + toClientname + ".txt"))
                                                    {
                                                        path = "Conversaciones/" + fromClientname + "-" + toClientname + ".txt";
                                                        StreamReader conversacion = new StreamReader(path);
                                                        //command = Utils.encriptar(conversacion.ReadToEnd());
                                                        command = conversacion.ReadToEnd();
                                                        buffer = Encoding.ASCII.GetBytes(command);
                                                        conversacion.Close();
                                                    }
                                                    else if (File.Exists("Conversaciones/" + toClientname + "-" + fromClientname + ".txt"))
                                                    {
                                                        path = "Conversaciones/" + toClientname + "-" + fromClientname + ".txt";
                                                        StreamReader conversacion = new StreamReader(path);
                                                        //command = Utils.encriptar(conversacion.ReadToEnd());
                                                        command = conversacion.ReadToEnd();
                                                        buffer = Encoding.ASCII.GetBytes(command);
                                                        conversacion.Close();
                                                    }
                                                    else
                                                    {
                                                        //command = Utils.encriptar("Inicia una conversacion.\n");
                                                        command = "Inicia una conversacion.\n";
                                                        buffer = Encoding.ASCII.GetBytes(command);
                                                    }
                                                    int aux = Encoding.Default.GetBytes(command).Length;
                                                    String cmd = "<IncomingChat><from>" +
                                                        fromClientname +
                                                        "<from><to>" +
                                                        toClientname+
                                                        "<to><size>"+
                                                        aux+
                                                        "<size><IncomingChat>";
                                                    c.sendStringMsg(cmd);
                                                    c.sendStringMsg(command);
                                                }//despues le llega al cliente y ve si contiene IncomingMessage o no
                                            }
                                            
                                        }
                                        else if (command.Contains("<CargaMuro>"))
                                        {
                                             
                                            string path;
                                            String[] mainSplit = command.Split(new String[] { "<CargaMuro>" }, StringSplitOptions.RemoveEmptyEntries);
                                                path = "Muros/" + mainSplit[0] + ".txt";
                                                String usuario = "";
                                                String publicacion = "";
                                                StreamReader rs = new StreamReader(path);
                                                
                                                while (rs.Peek() >= 0)
                                                {
                                                    
                                                    usuario = rs.ReadLine();
                                                    publicacion = rs.ReadLine();
                                                    String cmd = "<ActualizaMuro>" +
                                                    "<muro>" +
                                                    path +
                                                    "<muro><usuario>" +
                                                    usuario +
                                                    "<usuario><mensaje>" +
                                                    publicacion+
                                                    "<mensaje><ActualizaMuro>";
                                                    client.sendStringMsg(cmd);
                                                    Thread.Sleep(200);
                                                    //client.sendStringMsg(publicacion);
                                                }
                                                rs.Close();
                                            
                                            
                                        }
                                        else if (command.Contains("<EscribeMuro>"))
                                        {
                                            String[] mainSplit = command.Split(new String[] { "<EscribeMuro>" }, StringSplitOptions.RemoveEmptyEntries);
                                            //<size>1828<size><to>JAvier<to>
                                            string[] contentSplit = mainSplit[0].Split(new String[] { "<muro>", "<nombre>","<publicacion>" }, StringSplitOptions.RemoveEmptyEntries);
                                            //tamaño del mensaje
                                            String muro =contentSplit[0];
                                            //Para quien va el mensaje
                                            String nombre = contentSplit[1];
                                            String mensaje = contentSplit[2];
                                            String path = "Muros/" + muro + ".txt";
                                            StreamWriter escrito;
                                            escrito = File.AppendText(path);

                                            String contenido = "\r\n" + nombre + "\r\n" + mensaje;
                                            escrito.Write(contenido);
                                            escrito.Flush();
                                            escrito.Close();
                                        }
                                        else if (command.Contains("<WebcamRequest>"))
                                        {
                                            String[] mainSplit = command.Split(new String[] { "<WebcamRequest>", "<nombre>" }, StringSplitOptions.RemoveEmptyEntries);
                                            String usuario = mainSplit[0];
                                            foreach (Client c in mClients)
                                            {
                                                if (c.mName == usuario && c.mEstado != "desconectado")
                                                {
                                                    String cmd = "<WebcamRequest>" +
                                                    "<de>" + client.mName +
                                                    "<de><WebcamRequest>";
                                                    c.sendStringMsg(cmd);
                                                }
                                            
                                            }
                                        }
                                        else if (command.Contains("<WebcamAccept>"))
                                        {
                                            String[] mainSplit = command.Split(new String[] { "<WebcamAccept>", "<de>","<para>" }, StringSplitOptions.RemoveEmptyEntries);
                                            String usuario1 = mainSplit[0];
                                            String usuario2 = mainSplit[1];
                                            String ip1="";
                                            String ip2="";
                                            foreach (Client c in mClients)
                                            { 
                                                if (c.mName == usuario1)
                                                    ip1=c.mIp.ToString();
                                                if (c.mName == usuario2)
                                                    ip2 = c.mIp.ToString();
                                            }

                                            foreach (Client c in mClients)
                                            {
                                                if (c.mName == usuario1)
                                                {
                                                    String cmd = "<WebCamEstablish>" +
                                                    "<ip>" + ip2 +
                                                    "<ip><name>" + usuario2 + "<name><WebCamEstablish>";
                                                    c.sendStringMsg(cmd);
                                                }
                                                if (c.mName == usuario2)
                                                {
                                                    String cmd = "<WebCamEstablish>" +
                                                    "<ip>" + ip1 +
                                                    "<ip><name>" + usuario1 + "<name><WebCamEstablish>";
                                                    c.sendStringMsg(cmd);
                                                }

                                            }
                                        }
                                        else if (command.Contains("<MandaArchivo>"))
                                        {
                                            String[] mainSplit = command.Split(new String[] { "<MandaArchivo>", "<path>", "<size>", "<nombre>" }, StringSplitOptions.RemoveEmptyEntries);
                                            String path = mainSplit[0];
                                            int receiveSize = Int32.Parse(mainSplit[1]);
                                            String toClientname = mainSplit[2];
                                            buffer = new byte[receiveSize];
                                            client.mSocket.Receive(buffer);
                                            String newpath = "C:\\Users\\Alejandro\\Desktop\\POI\\FServer\\bin\\Debug\\Documentos\\" + path;
                                            File.WriteAllBytes(newpath, buffer);

                                            foreach (Client c in mClients)
                                            {
                                                if (c.mName == toClientname && c.mEstado != "desconectado")
                                                {
                                                    String cmd = "<RecibeArchivo>" +
                                                    "<path>" + path +
                                                    "<path><from>" + client.mName + "<from><RecibeArchivo>";
                                                    c.sendStringMsg(cmd);
                                                }

                                            }
                                        }
                                        else if (command.Contains("<FileDownload>"))
                                        {
                                            String[] mainSplit = command.Split(new String[] { "<FileDownload>","<path>" }, StringSplitOptions.RemoveEmptyEntries);
                                            String path = mainSplit[0];
                                            String newpath = "C:\\Users\\Alejandro\\Desktop\\POI\\FServer\\bin\\Debug\\Documentos\\" + path;

                                            Stream fs = File.OpenRead(newpath);
                                            System.IO.MemoryStream data = new System.IO.MemoryStream();
                                            fs.CopyTo(data);
                                            data.Seek(0, SeekOrigin.Begin);
                                            byte[] buf = new byte[data.Length];
                                            data.Read(buf, 0, buf.Length);
                                            command="<ReceiveFile><size>"+buf.Length+"<size><nombre>"+path+"<nombre><ReceiveFile>";
                                            client.sendStringMsg(command);
                                            client.mSocket.Send(buf);

                                        }
                                    }
                                }).Start();
                                Console.WriteLine("Nombre Cliente: " + client.mName);

                            }
                            catch (SocketException e)
                            {
                                Console.WriteLine("ERROR: Al recibir de socket");
                            }

                        }).Start();
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                }

            }).Start();
            
        }

        public void stopSocket()
        {
            mIsThreadRunning = false;
            mSocket.Close();
        }
    }
}
