
//inserting at the end of an array
int[] ntArray = new int[6];

int length  = 0;

for (int i = 0; i < 3; i++)
{
    ntArray[length] = i;
    length++;
}

ntArray[length] = 8;
length++;




/*// inserting 8 at the length of every 2 index
int[] ntArray1 = new int[6];

int length1 = 2;

for (int i = 0; i < 5; i++)
{
    ntArray1[length1] = 8;
    length1++;
    *//*    ntArray[length] = i + 1;
        length++;*//*
}
*/



// Add the the first three Index
int[] ntArray2 = new int[6];

int length2 = 0;

for (int i = 0; i <= 2; i++)
{
    ntArray2[length2] = 8;
    length2++;
}

// Inserting at the start of an array
int[] ntArray3 = new int[6];

for (int i = 3; i >= 0; i--)
{
    //this is moving over all the values
    ntArray3[i] = ntArray3[i];

}
ntArray3[0] = 20;

int value = 0;
