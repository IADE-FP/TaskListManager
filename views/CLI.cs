public class CLI {
    public static void Run() {
        // "RT Primeira tarefa" -> ["RT","Primeira","tarefa"]
        // "MT 42"
        // "LT"
        // "Q"
        while (true) {
            string line = Console.ReadLine();
            string[] tokens = line.Split(" ");
            string operation = tokens[0];
            if(operation == "RT") {

            }
            else if(operation == "LT") {
                
            }
            else if(operation == "MT") {

            }
            else if(operation == "Q") {

            }
        }
    }
}