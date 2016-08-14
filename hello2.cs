using System;
using System.Windows.Forms;

public class HelloWorld2 : Form {
    static public void Main() {
	Application.Run(new HelloWorld2());
    }

    public HelloWorld2() {
	Text = "Hello from MONO 2";
    }
}


