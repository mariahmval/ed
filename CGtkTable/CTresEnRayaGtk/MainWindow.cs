using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    private string jugador = "X";
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();

        Table table = new Table(3, 3, true);
        for (int row = 0; row < 3; row++)
            for (int column = 0; column < 3; column++) {
                Button button = new Button();
                table.Attach(button, (uint)column, (uint)column + 1, (uint)row, (uint)row + 1);
                button.Clicked += delegate {
                    if (button.Label != null)
                        return;
                    button.Label = jugador;
                    if (jugador == "X")
                        jugador = "O";
                    else
                        jugador = "X";
                };
            }

        vBox.Add(table);
        table.ShowAll();

        //Button[] buttons = new Button[] {button1, button2, button3, button4,
        //         button5, button6, button7, button8, button9};

        //foreach (Button button in buttons) {
        //    button.Clicked += delegate {

        //        button.Label = "X";

        //    };
        //}

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //protected void OnButtonClicked(object sender, EventArgs e)
    //{
    //    ((Button)sender).Label = "X";
    //}
}
