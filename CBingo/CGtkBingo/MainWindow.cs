using Gtk;
using System;
using System.Collections.Generic;

public partial class MainWindow : Gtk.Window
{
    private int celda = 0;
    private int indiceNumeros = 0;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        //Button[] buttons = new Button[90];
        List<Button> buttons = new List<Button>();
        int[] numeros = new int[90];
        for (int i = 0; i < 90; i++)
            numeros[i] = i + 1;
        UnsortArray(numeros);

        for (int row = 0; row < 9; row++)
            for (int column = 0; column < 10; column++) {
                Button button = new Button();
                celda++;
                button.Label = celda.ToString();
                table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                buttons.Add(button);
            }

        table.ShowAll();

        Random random = new Random();
        buttonAdelante.Clicked += delegate
        {
            if (indiceNumeros < 90)
            {
                labelNumero.Text = numeros[indiceNumeros].ToString();
                buttons[numeros[indiceNumeros] - 1].ModifyBg(StateType.Normal, new Gdk.Color(0, 255, 0));
                indiceNumeros++;
            }
            else
                labelNumero.Text = "Han salido todos los números";
        };

        buttonReiniciar.Clicked += delegate {

            labelNumero.Text = "Pulsa Adelante para iniciar una nueva ronda";
            indiceNumeros = 0;
            UnsortArray(numeros);

            for (int i = 0; i < 90; i++)
                buttons[i].ModifyBg(StateType.Normal, new Gdk.Color(255, 255, 255));

        };

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void UnsortArray(int[] v) {
        int n = v.Length;
        Random random = new Random();
        for (int i = 0; i < v.Length; i++)
        {
            int randomValue = i + random.Next(n-i);
            int randomElement = v[randomValue];
            v[randomValue] = v[i];
            v[i] = randomElement;
        }
    }

}
