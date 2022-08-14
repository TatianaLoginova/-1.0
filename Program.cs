// See https://aka.ms/new-console-template for more information




void Main(){
    string[] stringArray = {"1234", "15679", "-2", "Rus", "Den", "Kazan"};
    string[] stringArrayNew;
    Console.WriteLine("Hello, World!");
    int num = 0;
    int index = 0;

    
    for(int i = 1; i <= stringArray.Length; i++){
        Console.Write(i + " - ");
        Console.Write(stringArray[i-1].Length + " - ");
        Console.WriteLine(stringArray[i-1]);
        if(stringArray[i-1].Length <=3 ){
            num = num + 1;
        }
    };

    Console.WriteLine("Прошлись по массиву и определили количество строк, где символов небольше 3");
    stringArrayNew = new string[num];

    for(int i = 1; i <= stringArray.Length; i++){
        Console.Write(i + " - ");
        Console.Write(stringArray[i-1].Length + " - ");
        Console.WriteLine(stringArray[i-1]);
        if(stringArray[i-1].Length <=3 ){
            stringArrayNew[index] = stringArray[i-1];
            index = index + 1;
        }
    };

    Console.WriteLine("Прошлись по исходному массиву и стром с тремя или меньшими символами перезаписали в новый массив");
    

    for(int i = 1; i <= stringArrayNew.Length; i++){
        Console.Write(i + " - ");
        Console.Write(stringArrayNew[i-1].Length + " - ");
        Console.WriteLine(stringArrayNew[i-1]);
    };

    Console.WriteLine("Вывели итоговый массив");


}

Main();