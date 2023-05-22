using Microsoft.CodeAnalysis;

namespace MySolution.Gen;

[Generator]
public class HelloWorldGen : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(PostInitializationCallback);
    }

    private static void PostInitializationCallback(IncrementalGeneratorPostInitializationContext context)
    {
        context.AddSource($"{nameof(MySolution)}.g.cs", $@"public class HelloWorld {{ static public string Message => ""Hello World!""; }}");
    }
}
