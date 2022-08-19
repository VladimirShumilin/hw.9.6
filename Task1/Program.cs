using Exeptions;

var exceptions = new List<Exception>(5) { new ArgumentNullException(nameof(args), "Агрумент не определен"),
                new ArgumentOutOfRangeException(),
                new PlatformNotSupportedException(),
                new UnauthorizedAccessException(),
                new NumberExeption()};

foreach (Exception e in exceptions)
{
    try
    {
        throw e;
    }
    catch (ArgumentNullException ex) { Console.WriteLine($"{ex}\n{ex.HelpLink}"); }
    catch (ArgumentOutOfRangeException ex) { Console.WriteLine($"{ex}\n{ex.HelpLink}"); }
    catch (PlatformNotSupportedException ex) { Console.WriteLine($"{ex}\n{ex.HelpLink}"); }
    catch (UnauthorizedAccessException ex) { Console.WriteLine($"{ex.Message}\n{ex.HelpLink}"); }
    catch (NumberExeption ex) { Console.WriteLine($"{ex.Message}\n{ex.HelpLink}"); }
}
