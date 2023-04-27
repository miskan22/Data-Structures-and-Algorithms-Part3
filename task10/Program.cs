/*
- Give an array 21, 30, 11, 34, 20, 56, use diagrams to illustrate the step-by-step sorting
process using each of the following sorting algorithms.

- Insertion sort (what the array looks like after each pass)
=> Original array: 21, 30, 11, 34, 20, 56
    - Pass #1: Insert 30 into 21 and it becomes 21 30
    - Pass #2: Insert 11 into 21,30 and it becomes 11 21 30
    - Pass #3: Insert 34 into 11,21,30 and it becomes 11 21 30 34
    - Pass #4: Insert 20 into 11,21,30,34 and it becomes 11 20 21 30 34
    - Pass #5: Insert 56 into 11,20,21,30,34 and it becomes 11 20 21 30 34 56

- Merge sort (a diamond shape diagram showing each split and each merge)
=> Original array: 21 30 11 34 20 56
                        /  \
    - Split #1: 21 30 11    34 20 56 
                  /   \       /   \
    - Split #2: 21  30 11   34  20 56
                |   /   \   |   /   \
    - Split #3: 21  30  11  34  20  56
                |   \   /   |   \   /
    - Merge #1: 21  11 30   34  20 56
                \     /     \     /
    - Merge #2: 11 21 30    20 34 56
                    \           /
    - Merge #3: 11  20  21  30  34  56

- Quick sort (use the first element as pivot, and show what the array looks like after each partition)
=> Original array(unsorted): 21 30 11 34 20 56
    - a) Initialise pivot, low, and high: 21<pivot> 30<low> 11 34 20 56<high> 
    30 > pivot value, 56 > pivot value 
    (No swap - because 30 and 56 are bigger than pivot(21) so LEAVE 30 as where it is and move high pointer to 20)
    => 21<pivot> 30<low> 11 34 20<high> 56

    - b) Search forward and backward: 21<pivot> 30<low> 11 34 20<high> 56
    And then move high pointer to 20, 30 was stay at the low, 30 > pivot value, 20 < pivot value
    (Swap low with high - because 20 is smaller than 21)
    => 21<pivot> 20<low> 11 34 30<high> 56

    - c) Continue search: 21<pivot> 20<low> 11 34 30<high> 56
    move low pointer to 11 and high pointer to 34
    (No swap - because 11 is smaller than pivot and 34 is bigger than pivot)
    => 21<pivot> 20 11<low> 34<high> 30 56

    - d) When high < low, search is over: 21 20 11<high> 34<low> 30 56
    Until low and high cross each other
    (Swap pivot with high, array becomes the following)
    => 11 20 21<pivot> 34 30 56

    - e) Smaller subarray is sorted but larger subarray isn't sorted
    So now 34 is pivot and 30 is low and 56 is high
    => (11 20 21)sorted    34<pivot> 30<low> 56<high>

    - f) No swap - because 30 is smaller than 34 and 56 is larger than pivot
    Until low and high cross each other: 34<pivot> 30<high> 56<low>
    (Swap pivot with high, array becomes the following)
    => 11 20 21 30 34 56 (all sorted)
*/
