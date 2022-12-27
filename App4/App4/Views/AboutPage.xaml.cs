using System;
using System.ComponentModel;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        public void envoyer(object sender, EventArgs e)
        {
            var ad = adresse.Text;
            var p = port.Text;
            var m = message.Text;
            var clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint ip = new IPEndPoint(ad, 9999);
            clientSocket.Connect(ad,9999);
           Console.WriteLine($"le message est : {m}");
           var bytesToSend = Encoding.UTF8.GetBytes(m);
           clientSocket.Send(bytesToSend);
           

           //clientSocket.Close();
        }
    }
}