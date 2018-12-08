using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonSumaClicked(object sender, EventArgs e)
    {
        float num1 = float.Parse(entryNumero1.Text);
        float num2 = float.Parse(entryNumero2.Text);
        float suma = num1 + num2;
        labelResultado.Text = "" +suma;
    }

    protected void OnButtonMultiplicaClicked(object sender, EventArgs e)
    {
        float num1 = float.Parse(entryNumero1.Text);
        float num2 = float.Parse(entryNumero2.Text);
        float multiplicacion = num1 * num2;
        labelResultado.Text = "" +multiplicacion;
    }

    protected void OnButtonRestaClicked(object sender, EventArgs e)
    {
        float num1 = float.Parse(entryNumero1.Text);
        float num2 = float.Parse(entryNumero2.Text);
        float resta = num1 - num2;
        labelResultado.Text = "" +resta;
    }

    protected void OnButtonDividirClicked(object sender, EventArgs e)
    {
        float num1 = float.Parse(entryNumero1.Text);
        float num2 = float.Parse(entryNumero2.Text);
        float division = num1 / num2;
        labelResultado.Text = "" +division;
    }
}
