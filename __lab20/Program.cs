using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace __lab20
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите вариант использования: \n'[1]' - Однопоточный сервер и клиент\n'[2]' - Многопоточный сервер и клиент' ");
            int version = Int32.Parse(Console.ReadLine());
            switch (version) {
                case 1:
                    Task server = new Task(() => { OneThreadServer(); });
                    Task client = new Task(() => { ClientCommunicate(); });
                    server.Start();
                    client.Start();
                    Task.WaitAll(server, client);
                    break;
                case 2:
                    Task multiServer = new Task(() => { MultiThreadServer(); });

                    multiServer.Start();
                    Task newClient = new Task(() =>
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Соединение #{i}\n");
                            Connect("127.0.0.1", $"Hello World! #{i} ");
                        }
                    });
                    newClient.Start();
                    break;
            }
            Console.WriteLine("Нажмите Enter...");
            Console.ReadKey();
        }

        // Listing 1.1
        static void OneThreadServer()
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Однопоточный сервер запущен");

            // Подготавливаем конечную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8888);

            // Создаем потоковый сокет, протокол TCP/IP
            Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                // Связываем сокет с конечной точкой
                sock.Bind(ipEndPoint);
                // Начинаем прослушку сокета
                sock.Listen(10);

                // Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine($"Слушаем, порт {ipEndPoint}");

                    /* Программа приостанавливается,
                    ожидая входящее соединение
                    сокет для обмена данными с клиентами*/
                    Socket s = sock.Accept();

                    // Сюда будем записывать полученные от клиента данные
                    string data = null;

                    // Клиент есть, начинаем читать от него запрос
                    // массив полученных данных
                    byte[] bytes = new byte[1024];

                    // длина полученных данных
                    int bytesCount = s.Receive(bytes);

                    // Декодируем строку
                    data += Encoding.UTF8.GetString(bytes, 0, bytesCount);

                    // Показываем данные на консоли
                    Console.Write($"Данные от клиента: {data} \n\n");

                    // Отпрвляем ответ клиенту
                    string reply = "Query size: " + data.Length.ToString() + " chars";
                    // Кодируем ответ сервера
                    byte[] msg = Encoding.UTF8.GetBytes(reply);

                    // Отпрвляем ответ сервера
                    s.Send(msg);
                    if (data.IndexOf("<TheEnd>") > -1)
                    {
                        Console.WriteLine("Соединение завершено.");
                        break;
                    }
                    s.Shutdown(SocketShutdown.Both);
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.ReadLine();
            }
        }

        // Listing 1.2
        static void ClientCommunicate() {
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Thread.Sleep(2000);
            try
            {
                Communicate("localhost", 8888);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Console.ReadLine();
            }
        }
        static void Communicate(string hostname, int port)
        {
            // Буфер для вдодящих данных
            byte[] bytes = new byte[1024];

            // Соединяемся с удаленным сервером
            // Устанавливаем удаленную точку {сервер} для сокета
            IPHostEntry ipHost = Dns.GetHostEntry(hostname);
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sock = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Подключаемся к серверу
            sock.Connect(ipEndPoint);

            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();

            Console.WriteLine($"Подключаемся к порту {sock.RemoteEndPoint}");

            byte[] data = Encoding.UTF8.GetBytes(message);

            int bytesSent = sock.Send(data);

            // Получаем ответ от сервера, bytesRec - количество принятых байтов
            int bytesRec = sock.Receive(bytes);

            Console.WriteLine($"\nОтвет сервера: {Encoding.UTF8.GetString(bytes, 0, bytesRec)}\n\n");

            // Вызываем Communicate ещё раз
            if (message.IndexOf("<TheEnd>") == -1) 
            {
                Communicate(hostname, port);
            }

            // Освобождаем сокет
            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
        }

        // Listing 1.3
        static void MultiThreadServer() {
            TcpListener server = null;
            try
            {
                int MaxThreadsCount = Environment.ProcessorCount * 4;
                // Устанавливаем макс. количество рабочих потоков
                ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
                // Устанавливаем минимальное количество рабочих потоков
                ThreadPool.SetMinThreads(2, 2);

                // Устанавливаем порт для TcpListener = 9595
                Int32 port = 9595;
                IPAddress localAddr = IPAddress.Parse("127.0.0.1");
                int counter = 0;
                server = new TcpListener(localAddr, port);

                Console.OutputEncoding = Encoding.GetEncoding(866);
                Console.WriteLine("Конфигурация многопоточного сервера: ");
                Console.WriteLine($"    IP-адрес    : 127.0.0.1");
                Console.WriteLine($"    Порт    : {port}");
                Console.WriteLine($"    Потоки    : {MaxThreadsCount}");
                Console.WriteLine("\nСервер запущен\n");

                server.Start();

                while (true)
                {
                    Console.Write("\nОжидание соединения...");

                    // Принимаем нового клиента
                    TcpClient client = server.AcceptTcpClient();
                    counter++;
                    Console.WriteLine($"\nСоединение №{counter}!");

                    // Создаем новую задачу для обработки клиента
                    Task.Factory.StartNew(() =>
                    {
                        ClientProcessing(client); // Передаем клиента в метод ClientProcessing
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally 
            { 
                server.Stop();
            }

            Console.WriteLine("\nНажмите Enter...");
            Console.Read();
        }
        static void ClientProcessing(object client_obj) {
            // Буфер для принимаемых данных.
            Byte[] bytes = new Byte[256];
            String data;
            TcpClient client = client_obj as TcpClient;

            // Получаем информацию от клиента
            NetworkStream stream = client.GetStream();

            int i;

            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0) 
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i).ToUpper();
                
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
                stream.Write(msg, 0, msg.Length);
            }
            client.Close();
        }

        // Listing 1.4
        static void Connect(String server, String message) {
            try
            {
                Int32 port = 9595;
                TcpClient client = new TcpClient(server, port);

                Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);

                data = new Byte[256];

                String responseData = String.Empty;

                Int32 bytes = stream.Read(data, 0, data.Length);
                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                Console.WriteLine($"Получено: {responseData}");
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e) {
                Console.WriteLine($"ArgumentNullException: {e}");
            }
            catch (SocketException e)
            {
                Console.WriteLine($"SocketException: {e}");
            }
        }
    }
}
