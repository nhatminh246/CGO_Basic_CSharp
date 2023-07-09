﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mineText
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int[]dx =new int[] {-1, -1, -1, 0, 0, 1, 1 ,1};
            int[]dy = new int[] {-1, 0, 1, -1, 1, -1, 0, 1};
            int height = map.GetLength(0);
            int width = map.GetLength(1);
            int[,] map_2 = new int[width, height];
            List<int> list_x = new List<int>();
            List<int> list_y = new List<int>();
            int id = 0;

            for(int i = 0; i < width;i++){
                for(int j = 0; j < height;j++){
                    map_2[i,j] = 0;
                }
            }
            for(int i = 0; i < width; i++){
                for(int j = 0; j < height; j++){
                    if(map[i, j]=="*"){
                        list_x.Add(i);
                        list_y.Add(j);
                        for(int k = 0; k < 8; k++){
                            if((i+dx[k]>= 0 && i+dx[k]<width) && (j +dy[k]>=0 && j + dy[k]< width)){
                                map_2[i+dx[k], j+dy[k]]++;
                            }
                        } 
                    }
                }
            }
            list_x.Add(-1);
            list_y.Add(-1);


            for(int i = 0; i < width; i++){
                for(int j =0; j < height; j++){
                    if(i == list_x[id] && j == list_y[id]){
                        id++;
                        Console.Write("*");
                    }else{
                        Console.Write(map_2[i,j]);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}