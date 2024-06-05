using static System.Console;

WhatsMyNamespace();

void WhatsMyNamespace()
{
    WriteLine("Namespace of Program class: {0}", arg0: typeof(Program).Namespace ?? "null");
}