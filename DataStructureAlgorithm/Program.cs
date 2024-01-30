
//inserting at the end of an array
int[] ntArray = new int[] { 0, 1, 2, 3, 4, 5};

int length = 0;

for (int i = 0; i < 4; i++)
{
    ntArray[length] = i;
    length++;
}
ntArray[length] = 8;
length++;




// Inserting at the start of an array
for (int i = 3; i >= 0; i--)
{
    //this is moving over all the values
    ntArray[i+1] = ntArray[i];
}
ntArray[0] = 8;
int vlau = 0;


/*
// inserting 8 at the length of every 2 index
int[] ntArray1 = new int[6];

int length1 = 2;

for (int i = 0; i < 5; i++)
{
    ntArray1[length1] = 8;
    length1++;
    ntArray[length] = i + 1;
    length++;
}

// Add the the first three Index
int[] ntArray2 = new int[6];

int length2 = 0;

for (int i = 0; i <= 2; i++)
{
    ntArray2[length2] = 8;
    length2++;
}


ntArray3[0] = 20;

int value = 0;
*/

// inserting to anywhere in an array
int[] ntArray4 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
/*ntArray4[0] = 0;
ntArray4[1] = 2;
ntArray4[2] = 1;
ntArray4[3] = 5;
ntArray4[4] = 6;
ntArray4[5] = 7;*/

for (int i = 2; i <6; i++)
{
    //this is moving over all the values
   // ntArray4[i] = ntArray4[i];
    ntArray4[i] = 20;
    Console.WriteLine(ntArray4[i]);
}
ntArray4[7] = 20;
int value1 = 0;



// print out an array value 
foreach(int i in ntArray4)
{
    Console.WriteLine(i);
}


//Deleting from the end array
int Num = 0;
for (int i = 0;i < 7; i++)
{
    ntArray4[Num] = i;
    Num++;
}
// Num--;

// Deleting the first index
for(int i = 1;i < Num; i++)
{
    ntArray4[i-1] = ntArray4[i];
}
Num--;

for(int i =0; i < Num; i++)
{
    Console.WriteLine(ntArray4[i]);
}
