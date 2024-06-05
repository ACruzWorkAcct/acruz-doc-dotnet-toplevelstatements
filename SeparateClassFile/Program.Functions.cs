using static System.Console;

// Don't define namespace, class goes in *default* empty namespace

partial class Program
{
    static void WhatsMyNamespace()
    {
        WriteLine("Namespace of Program class: {0}",
        arg0: typeof(Program).Namespace ?? "null");
    }
}