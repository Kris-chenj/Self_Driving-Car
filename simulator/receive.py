import socket

HOST = '127.0.0.1'  # 本地IP地址
PORT = 12345       # 选择一个未被占用的端口号

def start_server():
    server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server_socket.bind((HOST, PORT))
    server_socket.listen(1)
    print("等待Unity连接...")
    conn, addr = server_socket.accept()
    print("连接成功！")

    while True:
        # 接收图片数据
        image_data = b''
        while True:
            data = conn.recv(1024)
            if not data:
                break
            image_data += data

        # 保存图片数据为图片文件
        with open('received_image.jpg', 'wb') as f:
            f.write(image_data)
        print("已接收图片")

        # 在这里运行预测脚本，获得预测的速度和角度值
        # 以下是一个示例，假设预测结果为speed和angle
        speed = 10.0
        angle = 45.0

        # 将预测的速度和角度值转换为字符串
        prediction = f"{speed},{angle}".encode()

        # 发送预测结果回Unity
        conn.sendall(prediction)

    conn.close()

if __name__ == '__main__':
    start_server()
