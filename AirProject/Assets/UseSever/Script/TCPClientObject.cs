using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

using System.Threading;
using System.Timers;

public class AutoTCPClient
{
    private TcpClient m_client = new TcpClient();
    private System.Timers.Timer m_timer = new System.Timers.Timer();
    private IPEndPoint remoteEP;

    public  delegate void TCPEvent();
    public event TCPEvent OnConnected;
    public event TCPEvent OnDisconnected;

    public AutoTCPClient()
    {
        m_timer.Interval = 1000;
        m_timer.Elapsed += new ElapsedEventHandler(CheckAlive);
    }

    public void AutoConnect(IPAddress address, int port)
    {
        remoteEP = new IPEndPoint(address, port);
        m_timer.Start();
    }

    private void CheckAlive(object source, ElapsedEventArgs e)
    {
        try
        {
            if (m_client.Connected)
            {
                if (m_client.Client.Poll(1000, SelectMode.SelectRead) && m_client.Available == 0)
                {
                    CloseConnect();
                }
            }
            else
            {
                
            }
        }
        catch (Exception ex)
        {

        }
    }

    private void CloseConnect()
    {
        if (m_client.Connected)
        {
            m_client.Client.Close();
            m_client = new TcpClient();
            if (OnDisconnected != null)
            {
                OnDisconnected();
            }
        }
    }

    public void AutoClose()
    {
        m_timer.Stop();
        CloseConnect();
    }

    public bool SendPackect(byte[] a_packect)
    {
        try
        {
            if (m_client.Connected)
            {
                NetworkStream ns = m_client.GetStream();
                if (ns.CanWrite)
                {
                    ns.Write(a_packect, 0, a_packect.Length);
                    return true;
                }
            }
        }
        catch (Exception ex)
        {

        }

        return false;
        
    }
}