using static System.Console;

WhatsMyNamespace();

void WhatsMyNamespace()
{
    // Validate code in default "null" namespace
    WriteLine("Namespace of Program class: {0}", arg0: typeof(Program).Namespace ?? "null");
}