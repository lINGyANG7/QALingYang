using System;
using System.Linq;
using System.Collections.Generic;

namespace LingYang
{
    class Program
    {
        
        static void Main(string[] args)
        {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ling\Desktop\QAEngineerChallenge\src\5.txt");
        List <int> count = new List<int>(); 
        int index = 0;
        bool fileEnd = false;
        int numberIndex = 0;
        int count1 = 0;
        //Find repeat number within a .txt file
        while(fileEnd == false){
        count1=0;
        //Count when find the same number
        for (int i = 0; i <lines.Length;i++){
            if (lines[i]== lines[numberIndex]){
                count1++;
            }
        }
        //Add count number into an array
        count.Add(count1);
        //make sure compare all the value in the file
        numberIndex++;
        if(numberIndex == lines.Length){
             fileEnd = true;
         }
        }
        
        int [] ans = count.ToArray(); 
        int min = ans[index];
        //find smallest number's index
        for (int i = 0;i<ans.Length;i++){
            if (count[i]<min){
                min = count[i];
                index = i;
            }
        }
       String output = "Number:\t" + lines[index] +"\t"+ "Repetead:\t" +min;
       System.IO.File.WriteAllText(@"C:\Users\ling\Desktop\QAEngineerChallenge\LingYang\output\output.txt",output);
    }
    }
}