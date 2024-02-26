using System.Collections.Generic;
class Coll
{
    void Learn()
    {
        // One dimensional
        byte[] ages = [23,21,45,67,88,9];
        string[] names =["Sita","Rita","2233"];
        //Multi
        int [,] studentsinClassRoom = new int[7,6];
        studentsinClassRoom[0,0]=0;
        studentsinClassRoom[0,1]=1;
        studentsinClassRoom[0,2]=2;
        studentsinClassRoom[0,3]=3;
       //Jagged array
       int [][] studentsinClassRooms = [[1,2,3],[3,4],[2,4,5,6]];
       //collections
       List<int> ageList= [3,4,5,6,7];
        List<string> nameList= ["Smriti","Ram"]; // O(n)

        Dictionary<string,long> countryPopulation= new();
        countryPopulation.Add("Nepal", 387428783);
        countryPopulation.Add("India", 38742878224);
        countryPopulation.Add("US", 7787428783);
        countryPopulation.Add("China", 245428783);
        var p= countryPopulation["India"];

        
    }
}