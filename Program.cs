
Console.WriteLine("массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");

             int rd () {
              // метод котрый возвращает рандомное число
              Random rnd=new Random();
             int a = rnd.Next(100,999);
             return a;
             }
             //создаём массив
            Console.Write("задайте длинну массива");
            int index=int.Parse( Console.ReadLine()), indexm ; 
            int [] mas = new int [index];
			arr(index);
            //метод который заполняет массив случайными числами
			int arr( int index){
            indexm=index-1;
            int a;
            ///заполняем массив
           while(indexm>=0){ 
            a=rd();
           mas[indexm]=a;
				indexm--;
				}
              
                return 0;
                } 

                int counter(){
                    int result=0;
                for(int indexm=0;indexm<mas.GetLength(0);indexm++)
				{
					int g,t;
					g=mas[indexm];
                    t = g%2;
                    if(t==0){result++;}
				}
                return result;
                }
                Console.WriteLine("показывает количество чётных чисел в массиве");
                Console.WriteLine(counter());
                Console.WriteLine("/////////////////////////////////////////////////////");


                ////////////////////////////////////////////////////////////////////////////////////////

                Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
                int summ(){
                     int result=0;
                    for(int indexm=0;indexm<mas.GetLength(0);indexm++)
				{
					int g,t;
					g=mas[indexm];
                    t = g%2;
                    if(t!=0){result=result+g;}
				} 
                return result;
                }
                 Console.WriteLine("Находит сумму элементов, стоящих на нечётных позициях.");
                Console.WriteLine(summ());
                Console.WriteLine("/////////////////////////////////////////////////////////////////");
                
                Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
                 double  rdD () {
              // метод котрый возвращает рандомное число
              Random rnd=new Random();
             double a = rnd.Next(100,999);
             return a;
             }
             //создаём массив
            
            double[] masD = new double [index];
			arr(index);
            //метод который заполняет массив случайными числами
			double arrD( int index){
            indexm=index-1;
            double a;
            ///заполняем массив
           while(indexm>=0){ 
            a=rdD();
           masD[indexm]=a;
				indexm--;
				}
                return 0;
                } 
                double diffAC(){
                    double a=0,b,c=0;
                    for(int i =0;i<masD.GetLength(0);i++){
                     b=masD[i];
                        if (a<b) {a=b;}
                       
                    }
                    c=c+a;
                    for(int i =0;i<masD.GetLength(0);i++){
                         b=masD[i];
                    if (c>b){c=b;}}
                     a=a-c;
                    return a ;
                }
                arrD(index);
                Console.WriteLine("разница между максимальным и минимальным элементов массива вещественных чисел");
                Console.WriteLine(diffAC());