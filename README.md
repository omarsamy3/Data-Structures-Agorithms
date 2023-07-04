# Data-Structures-Agorithms
This is a repo for implementing different kinds of data structures and algorithms as training.

## Big O Notation
The `Big O notation` is a mathematical notation used in computer science to describe the performance or efficiency of an algorithm. It provides a way to analyze and compare the worst-case behavior of algorithms as the size of the input increases.

In Big O notation, an algorithm is represented by O(f(n)), where "f(n)" is a function that characterizes the algorithm's time complexity or space complexity in terms of the input size "n." The "O" stands for "order of" and represents the upper bound or worst-case scenario.

The function "f(n)" typically represents the number of operations or steps required by the algorithm to solve a problem of size "n." However, the exact number of operations is not important; what matters is how the algorithm's performance scales with increasing input size.

Here are some common Big O notations and examples of data structures that use them:

1. `O(1)` - Constant time complexity:
   * Examples: Array, Linked List (insertion and deletion at the beginning), Hash table (average case lookup)

2. `O(log n)` - Logarithmic time complexity:
   * Examples: Binary search tree (search, insertion, deletion), Balanced binary search tree (e.g., AVL tree, Red-Black tree)

3. `O(n)` - Linear time complexity:
   * Examples: Array (search, traversal), Linked List (search, traversal), Queue, Stack, Hash table (worst case lookup)

4. `O(n log n)` - Linearithmic time complexity:
   * Examples: Merge Sort, Quick Sort, Heap Sort

5. `O(n^2)` - Quadratic time complexity:
   * Examples: Bubble Sort, Insertion Sort, Selection Sort

6. `O(2^n)` - Exponential time complexity:
   * Examples: Traveling Salesman Problem (brute force), Subset Generation (powerset generation)

These are just a few examples of common time complexities and the data structures or algorithms that exhibit them. It's worth noting that there are many other complexities and variations beyond these. The choice of data structure and algorithm depends on the specific problem at hand, the expected input size, and the desired trade-offs between time complexity and other factors such as memory usage.

![BigONotation](https://github.com/omarsamy3/Data-Structure-Agorithms/assets/76973221/58645f89-7da2-432a-96ab-a3a1772a4cba)

## Data Structures
(Array - Linked List - Stack - Queue - Hash Table ...)
### Array
The array is a fundamental and widely used data structure in computer programming. It is a collection of elements of the same type, stored in contiguous memory locations. Arrays provide efficient random access to elements based on their indices and allow for constant-time access to any element.

Here are some key characteristics and operations associated with arrays:

1. `Indexing`: Elements in an array are accessed using their indices, which are typically zero-based. The index represents the position of an element within the array. For example, in a 0-based array, the first element is accessed using index 0, the second element with index 1, and so on.

2. `Random access`: Arrays provide constant-time random access to elements. Given an index, an element can be directly accessed in O(1) time. This makes arrays efficient for reading, writing, or modifying elements at a specific index.

3. `Contiguous memory`: Array elements are stored in consecutive memory locations, which allows for efficient memory access and cache utilization. It enables the processor to fetch elements quickly as they are stored contiguously.

4. `Fixed size`: In most programming languages, arrays have a fixed size specified during declaration. Once created, the size of the array cannot be changed dynamically. However, dynamic arrays or resizable arrays are available in some languages that automatically resize as elements are added or removed.

5. `Homogeneous elements`: Arrays hold elements of the same type. This ensures that each element occupies the same amount of memory, allowing for efficient indexing and calculation of element positions.

6. `Iteration`: Arrays can be easily traversed using loops, such as for loops or while loops. Iterating over an array allows you to process or operate on each element in a sequential manner.

7. `Multidimensional arrays`: Arrays can have multiple dimensions, forming matrices or higher-dimensional structures. For example, a 2D array represents a table or grid with rows and columns, and a 3D array represents a three-dimensional space.

Arrays have a variety of applications and are used in numerous algorithms and data structures. They are commonly used for tasks such as storing collections of data, implementing stacks, queues, matrices, and dynamic programming algorithms.

It's important to note that arrays have certain limitations. Their fixed size can lead to inefficiency when elements need to be inserted or deleted in the middle of the array since it requires shifting elements. Additionally, resizing a static array can be costly as it involves creating a new array and copying elements.

To overcome these limitations, dynamic array implementations like ArrayList in Java or vectors in C++ provide resizable arrays with automatic resizing capabilities, making them more flexible for handling changing data sizes.

Overall, arrays are a fundamental building block in programming, offering fast and efficient access to elements and enabling a wide range of data processing and storage tasks.
![ArrayONotation](https://github.com/omarsamy3/Data-Structures-Agorithms/assets/76973221/b5cde9d3-78d5-49ad-8fa3-6a55072ad5d2)
