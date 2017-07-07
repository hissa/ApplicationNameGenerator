using System;
class ProcessNameTest{
    static void Main(string[] args){
        string input = "";
        Console.WriteLine("入力した文字列をタイトルに設定します。");
        Console.WriteLine("何も入力せずにEnterを入力すると終了します。");
        do{
            input = Console.ReadLine();
            Console.Title = input;
        }while(input != "");
    }
}