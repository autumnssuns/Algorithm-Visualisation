# 𝗠𝗶𝗻𝗶-𝗣𝗿𝗼𝗷𝗲𝗰𝘁: 𝗦𝗼𝗿𝘁𝗶𝗻𝗴 𝗔𝗹𝗴𝗼𝗿𝗶𝘁𝗵𝗺𝘀 𝗩𝗶𝘀𝘂𝗮𝗹𝗶𝘀𝗮𝘁𝗶𝗼𝗻
(12/6/2021 - 13/6/2021)
This mini-project was conducted to better understand how different sorting algorithms (taught in QUT's CAB301 - Algorithms and Complexity) work. The project includes a GUI Application (a Windows Form) written in C# that visualises several sorting algorithms.

## 𝙄𝙢𝙥𝙡𝙚𝙢𝙚𝙣𝙩𝙚𝙙 𝘼𝙡𝙜𝙤𝙧𝙞𝙩𝙝𝙢𝙨
- Insertion Sort: Moves each unsorted element to an appropriate position in the sorted part of the array.
- Selection Sort: Finds the minimum element and (kind of) move it towards the start (sorted part) of the array.
- Bubble Sort: Exchanges elements in pair so that the greater elements are moved toward the end of the array.
- Merge Sort: Recursively divides the array into smaller arrays, then sort these arrays and merge into a sorted array.
- Quick Sort: Recursively partitions the array into halves based on a pivot element, where lesser elements are placed towards the left of the pivot and greater the right.
- Heap Sort: Repeatedly transforms the unsorted part of the array into a heap, followed by a maximum key deletion that appends to the sorted part of the array (towards the end).

## 𝙉𝙤𝙩𝙖𝙗𝙡𝙚 𝙁𝙚𝙖𝙩𝙪𝙧𝙚𝙨
- An array of non-negative integers is parsed from a text box via regular expressions.
- The array can be inputed manually, or randomly generated.
- Each element is represented by a column, where the height and the colour of the column indicate the size of the integer.
- Has a memory so that any saved state in a completed sort can be accessed later.

## 𝙇𝙞𝙢𝙞𝙩𝙖𝙩𝙞𝙤𝙣𝙨
- Array size is bounded by the computer's display where each element requires at least 1 pixel to be displayed.
- There is only one "memory slot" that gets overriden when a new sort is performed.
- Only assignments are stored in the memory while comparisons are not.

## 𝙒𝙝𝙖𝙩'𝙨 𝙣𝙚𝙭𝙩 (If this project is ever revisited, which is unlikely)
- More algorithms: The interface should be applied to other algorithms (hopefully)...
- More types of input: Uniformly distributed pseudo-random variables is just too generic, maybe consider semi-sorted arrays and other forms of distributions?
- Timer: For empirical analysis, although execution time isn't the most reliable...
- Multi-tasking: To compare how different algorithms perform against each other, possibly after there are multiple types of input...
