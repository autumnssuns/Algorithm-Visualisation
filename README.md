___This is not a complete application. I am not actively working on this project, and there is no plan to revisit it any time in the near future.___


__[Demo video](http://www.youtube.com/watch?v=sIWiMuy9-zM "Sorting Algorithms Visualisation Demo")__

[![Sorting Algorithms Visualisation Demo](http://img.youtube.com/vi/sIWiMuy9-zM/0.jpg)](http://www.youtube.com/watch?v=sIWiMuy9-zM "Sorting Algorithms Visualisation Demo")

# 𝗠𝗶𝗻𝗶-𝗣𝗿𝗼𝗷𝗲𝗰𝘁: 𝗦𝗼𝗿𝘁𝗶𝗻𝗴 𝗔𝗹𝗴𝗼𝗿𝗶𝘁𝗵𝗺𝘀 𝗩𝗶𝘀𝘂𝗮𝗹𝗶𝘀𝗮𝘁𝗶𝗼𝗻
Initial commit: 12/6/2021
Last updated: 23/6/2021
- Added a stopwatch
- The main window also display the data size

This mini-project was conducted to better understand how different sorting algorithms (taught in QUT's CAB301 - Algorithms and Complexity) work. The project includes a GUI Application (a Windows Form) written in C# that visualises several sorting algorithms.

## Implemented Algorithms
- Insertion Sort: Moves each unsorted element to an appropriate position in the sorted part of the array.
- Selection Sort: Finds the minimum element and (kind of) move it towards the start (sorted part) of the array.
- Bubble Sort: Exchanges elements in pair so that the greater elements are moved toward the end of the array.
- Merge Sort: Recursively divides the array into smaller arrays, then sort these arrays and merge into a sorted array.
- Quick Sort: Recursively partitions the array into halves based on a pivot element, where lesser elements are placed towards the left of the pivot and greater the right.
- Heap Sort: Repeatedly transforms the unsorted part of the array into a heap, followed by a maximum key deletion that appends to the sorted part of the array (towards the end).

## Notable Features
- An array of non-negative integers is parsed from a text box via regular expressions.
- The array can be inputed manually, or randomly generated.
- Each element is represented by a column, where the height and the colour of the column indicate the size of the integer.
- Has a memory so that any saved state in a completed sort can be accessed later.
- Starts a stopwatch on sorting.

## Limitations
- Array size is bounded by the computer's display where each element requires at least 1 pixel to be displayed.
- There is only one "memory slot" that gets overriden when a new sort is performed.
- Only assignments are stored in the memory while comparisons are not.

## Known issues:
- Pressing Reset or Restart when a sorting is in place will throw an exception

## What's next
- More algorithms: The interface should be applied to other algorithms (hopefully)...
- More types of input: Uniformly distributed pseudo-random variables is just too generic, maybe consider semi-sorted arrays and other forms of distributions?
- Multi-tasking: To compare how different algorithms perform against each other, possibly after there are multiple types of input...
