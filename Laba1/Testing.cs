using System;


namespace TestingClass
{
    public class Testing
    {
        int pos = 0;

        Random random = new Random();

        private ArrayListClass.ArrayList myArrayList = new ArrayListClass.ArrayList();
        private ChainArrayClass.ChainArray myChainArray = new ChainArrayClass.ChainArray();

        public void Test()
        {
            for (int i = 0; i<=10000; i++) {
                int pos = random.Next();
                int data = random.Next();
                int RandomMethod = random.Next(1, 5);

                switch (RandomMethod)
                {
                    case 1:
                        myArrayList.Add(data);
                        myChainArray.Add(data);
                        break;
                    case 2:
                        myArrayList.Insert(data, pos);
                        myChainArray.Insert(data, pos);
                        break;
                    case 3:
                        myArrayList.Delete(pos);
                        myChainArray.Delete(pos);
                        break;
                    case 4:
                        myArrayList.Clear();
                        myChainArray.Clear();
                        break;
                }
            }
            Boolean check = myArrayList.Count() == myChainArray.Count();
            for (int i = 0; i < myArrayList.Count(); i++)
            {
                for (int j = 0; j <= i; j++) {
                    check = check && myArrayList.mas[i] == myChainArray[i];
                }
                if (!check)
                {
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("Ошибка при тестировании, списки различны!");
            }
            else 
            {
                Console.WriteLine("Итоговый список:\n");
                myChainArray.Print();
                Console.WriteLine();
                Console.WriteLine("Проверка прошла успешно!");
            }
        }
    }
}
