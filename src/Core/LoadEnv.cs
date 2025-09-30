using dotenv.net;

namespace Core;

public class LoadEnv
{
  public static void Run(string file = ".env")
  {
    DotEnvOptions envOptions = new(envFilePaths: [$"../../{file}"]);

    DotEnv.Load(envOptions);
  }
}