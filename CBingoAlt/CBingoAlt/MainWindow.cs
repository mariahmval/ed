using System;
using Gtk;

using CBingoAlt;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        Panel panel = new Panel(vBox);
        Bombo bombo = new Bombo();

        buttonAdelante.Clicked += delegate {
            int numero = bombo.SacarBola();
            panel.Marcar(numero);
            labelNumero.Text = numero.ToString();
            buttonAdelante.Sensitive = bombo.QuedanBolas();
            //if (!bombo.QuedanBolas())
                //buttonAdelante.Sensitive = false;
        };


    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
