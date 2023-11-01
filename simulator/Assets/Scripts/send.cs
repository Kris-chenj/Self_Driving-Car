using UnityEngine;
using System.Net.Sockets;

public class ImageSender : MonoBehaviour
{
    public string serverIP = "127.0.0.1";  // 本地IP地址
    public int serverPort = 12345;        // 与Python服务器使用的相同端口号

    public CameraSensor cameraSensor;     // CameraSensor脚本的引用

    TcpClient tcpClient;

    private void Start()
    {
        tcpClient = new TcpClient();
    }

    public void SendImageToPython()
    {
        byte[] imageData = cameraSensor.GetImageBytes();

        try
        {
            tcpClient.Connect(serverIP, serverPort);

            // 发送图片数据
            tcpClient.SendData(imageData);

            // 接收预测结果
            byte[] predictionData = new byte[1024];
            int bytesRead = tcpClient.ReceiveData(predictionData);

            // 将接收到的预测结果转换为字符串
            string prediction = System.Text.Encoding.ASCII.GetString(predictionData, 0, bytesRead);
            Debug.Log("Received prediction: " + prediction);

            // 这里你可以解析prediction字符串并对预测值进行处理
            // 例如，将预测的速度和角度值用于控制Unity中的物体运动
        }
        catch (SocketException ex)
        {
            Debug.Log("SocketException: " + ex.Message);
        }
        finally
        {
            tcpClient.Disconnect();
        }
    }
}
