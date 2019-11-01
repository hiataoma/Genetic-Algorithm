using System;
using System.Collections.Generic;

namespace GA
{

    class GA
    {
        //设置基因的数量
        int COUNT = 10;
        //设置染色体的数量
        static int chrome_number = 90;
        //设置最大的循环次数
        int MAXLOOP = 700;
        //设置交叉的概率
        double CROSS_PROBABILITY = 0.8;
        //设置变异的概率
        double CHANGE_PROBABILITY = 0.01;
        //适应值不改变的次数
        int suitability_unchange_count = 0;

        //客户的需求量质量
        int[] m = { 20,30,40,50,60,70,80,90,13,35};

        //客户的需求体积
        int[] v = { 20, 30, 40, 50, 60, 70, 80, 90, 13, 35 };   
        //设置车的数量
        int[] vehcile_num = { 3, 4, 5};
        
        //设置车的限制条件
        
        //设置初始种群
        int[][] chromesome_group = new int[chrome_number][];
        //设置新的种群的数量
        int[][] chromesome_new_group;
        public int[] RandomArr(int[] arr) {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++) {
                int index = r.Next(arr.Length);//随机获得0（包括0）到arr.Length（不包括arr.Length）的索引
                //Console.WriteLine("index={0}", index);//查看index的值
                int temp = arr[i];  //当前元素和随机元素交换位置
                arr[i] = arr[index];
                arr[index] = temp;
            }
            return arr;
        }
        //进行解码操作
        public void caculatefitness() {
            //打印种群数据
            /* for (int i=0; i < chrome_number; i++) {
                 for (int j = 0; j < 10; j++) {
                     Console.Write(chromesome_group[i][j]);
                 }
                 Console.WriteLine();
             }*/
            //设定适应值函数
            //进行解码
            for (int i=1;i<10 ;i++) {
                for (int j = 0; j < 10; j++) {
                    //解码

                }
            }

        }
        public void initialization() {
            int[] sixah = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0;i< chrome_number; i++) {
                RandomArr(sixah);
                chromesome_group[i] = new int[10];
                //随机打乱的数据组合成一个种群
                for (int j = 0; j < sixah.Length; j++) {
                    chromesome_group[i][j] = sixah[j];
                }                    
            }
        }
        //选择适应度最高的COUNT个染色体作为父种群
        public void selection()
        {

        }
        //交叉产生新的种群
        public void cross()
        {
            // var flag [count]int
            // for i, j := 0; i < COUNT; i++ {
            // 	for {

            // 	}
            // }
        }
        static void Main(String[] args)
        {
            

            //设置染色体组

            //设置最优染色体

            //设置子染色体组

            //检查是否达到最优

            //变异操作

            //记录每次最优的情况



            //按照适应度对种群的个体进行排序
            /*
                func SortSuit()
            {

            }
             */
            GA g = new GA();
            g.initialization();
            g.caculatefitness();

        }
    }
}
