using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tools.Generator
{
    public class Generator
    {
        public List<string> Content { get; set; }
        public string Path { get; set; }
        public TypeFormat Format { get; set; }
        public TypeCharacter Character { get; set; }

        public void Save()
        {
            string result = "";
            result = Format == TypeFormat.Json ? GetJson() : GetPipe();
            if (Character == TypeCharacter.Uppercase) result.ToUpper();
            if (Character == TypeCharacter.Lowercase) result.ToLower();

            File.WriteAllText(Path, result);
        }

        public string GetJson() => JsonSerializer.Serialize(Content);
        public string GetPipe() => Content.Aggregate((accum, current) => accum + "|" + current);
    }
}
