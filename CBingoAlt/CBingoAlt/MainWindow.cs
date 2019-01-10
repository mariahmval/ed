﻿using System;
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
            int numero = bombo.sacarBola();
            panel.Marcar(numero);
        };


    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
