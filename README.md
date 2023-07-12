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

### LinkedList
The LinkedList data structure is a popular linear data structure used in computer programming. Unlike arrays, which use contiguous memory locations to store elements, a linked list consists of individual nodes, each containing a value and a reference (or link) to the next node in the sequence.

Here are some key characteristics and operations associated with linked lists:

1. `Dynamic size`: Linked lists have a dynamic size and can grow or shrink as elements are added or removed. They do not have a fixed size limitation like arrays.

2. `Node structure`: Each node in a linked list contains two components: the value of the element and a reference (or pointer) to the next node in the sequence. The last node typically points to null, indicating the end of the list.

3. `Insertion and deletion`: Adding or removing elements in a linked list is efficient, especially at the beginning or end. To insert a new node, the link of the previous node is redirected to the new node, and the new node's link is set to the next node. To delete a node, the link of the previous node is adjusted to skip the deleted node.

4. `Sequential access`: Linked lists provide sequential access to elements, meaning elements are accessed sequentially from the first node to the last node. Random access to specific elements, as in arrays, is not as efficient in linked lists.

5. `Singly linked list vs. doubly linked list`: In a singly linked list, each node contains a reference to the next node, allowing traversal in only one direction. In contrast, a doubly linked list has nodes with references to both the next and previous nodes, enabling bidirectional traversal.

6. `Circular linked list`: A circular linked list is a variant where the last node's reference points back to the first node, forming a loop. This allows continuous traversal without a definite end.

Linked lists offer several `advantages` and `use cases`:

- `Dynamic size`: Linked lists are efficient for situations where the size of the collection can change frequently, as they can easily grow or shrink as needed.

- `Insertion and deletion`: Linked lists excel in scenarios where frequent insertions or deletions occur, especially at the beginning or end of the list, as it only requires adjusting the links.

- `Memory efficiency`: Linked lists use memory more flexibly compared to arrays, as each node only requires memory for its value and the link to the next node.

However, linked lists also have some `drawbacks`:

- `Sequential access`: Random access to specific elements in a linked list is not efficient, as each element must be traversed from the beginning until reaching the desired position.

- `Extra memory overhead`: Linked lists require additional memory to store the link/reference for each node, which can increase memory consumption compared to arrays.

- `Lack of direct access`: Unlike arrays, linked lists do not offer constant-time random access based on indices. Accessing an element at a particular position may require traversing the list from the beginning.

It's important to choose the appropriate data structure based on the specific requirements of your application. Linked lists are commonly used in scenarios where frequent insertion or deletion of elements is needed or when the collection size is expected to change dynamically.

### LinkedList vs Array
|                  | Arrays                         | Linked Lists                                |
| ---------------- | ------------------------------ | ------------------------------------------- |
| Memory           | Contiguous block of memory     | Individual nodes with memory for value/link |
| Size             | Fixed size                     | Dynamic size                                |
| Insertion        | Costly for middle elements     | Efficient, especially at beginning/end      |
| Deletion         | Costly for middle elements     | Efficient, especially at beginning/end      |
| Random Access    | Efficient (O(1))              | Inefficient (O(n)), sequential traversal   |
| Memory Overhead  | Minimal                        | Extra memory for links                      |
| Memory Utilization | May waste memory if not fully utilized | Flexible memory usage                     |
| Implementation    | Simpler                         | Requires maintaining links between nodes    |
| Usage            | When size is known and access by index is important | When dynamic size and efficient insertions/deletions are required |
