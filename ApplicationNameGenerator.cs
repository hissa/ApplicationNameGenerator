using System;
class ProcessNameTest{
    static void Main(string[] args){
        string input = "";
        if(args.Length > 0){
            input = args[0];
            Console.Title = input;
            Console.WriteLine("コマンドライン引数に渡された{0}が設定されました。", input);
        }
        Console.WriteLine("入力した文字列をタイトルに設定します。");
        Console.WriteLine("何も入力せずにEnterを入力すると終了します。");
        do{
            input = Console.ReadLine();
            Console.Title = input;
        }while(input != "");
    }
}