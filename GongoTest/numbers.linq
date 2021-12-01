<Query Kind="Statements" />

var nums = new List<int>();
int testing = 0;
//a
while(nums.Count < 1000) {
	Random rnd = new Random();
	int randomNum = rnd.Next(1, 100);	
	nums.Add(randomNum);
	Console.WriteLine(testing + ":" + randomNum);
	testing++;
}
//b
nums.RemoveAll(i => i % 2 == 1);

testing = 0;
foreach(int num in nums) {
	Console.WriteLine(testing + ":" + num);
	testing++;
}

//c
nums = nums.OrderByDescending(x => x).ToList();
var uniqueList = nums.GroupBy(x => x)
    .OrderByDescending(x => x.Count())
    .Select(x => x.Key)
    .ToList();
	
int[] numCounts = new int[uniqueList.Count];
for(int i = 0; i < uniqueList.Count; i++) {
	numCounts[i] = 0;
}
int count = 0;
foreach(int unique in uniqueList) {
	foreach(int num in nums) {
		if(num == unique)
			numCounts[count]++;
	}
	count++;
}

foreach(int num in uniqueList) {
	Console.WriteLine("unique:" + num);
}


foreach(int num in numCounts) {
	Console.WriteLine(num);
}