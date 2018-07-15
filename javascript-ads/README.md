# Javascript Data Structures and Algorithms

This is a repository of various data structures and algorithms that have been implemented using the Javascript programming language.

---

## Contents

* [Developed With](#developed-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Install](#install)
  * [Running Tests](#running-tests)
    * [Algorithm Tests](#algorithm-tests)
    * [Data Structure Tests](#data-structure-tests)

---

## Developed With

* [Visual Studio Code](https://code.visualstudio.com/) - A source code editor developed by Microsoft for Windows, Linux and macOS. It includes support for debugging, embedded Git control, syntax highlighting, intelligent code completion, snippets, and code refactoring

* [Node.js](https://nodejs.org/en/) - Javascript runtime

* [Jest](https://facebook.github.io/jest/) - Jest is used by Facebook to test all JavaScript code including React applications. One of Jest's philosophies is to provide an integrated "zero-configuration" experience.

---

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

The following software is required to be installed on your system:

* Node 8.x
* Npm 3.x

Type the following commands in the terminal to verify your node and npm versions

```bash
node -v
npm -v
```

### Install

Follow the following steps to get development environment running.

* Clone _'algorithms-and-data-structures'_ repository from GitHub

  ```bash
  git clone https://github.com/drminnaar/algorithms-and-data-structures.git
  ```

  _OR USING SSH_

  ```bash
  git clone git@github.com:drminnaar/algorithms-and-data-structures.git
  ```

* Install node modules

  ```bash
  cd algorithms-and-data-structures/javascript-ads/src
  npm install
  ```

### Running Tests

To run all tests in the project, type the following command:

```javascript
npm test
```

Furthermore, each algorithm or data structure will have it's own test.

For example:

* Change to src directory

   ```bash
   cd algorithms-and-data-structures/javascript-ads/src
   ```

* Run All Tests

  ```bash
  npm test
  ```

#### Algorithm Tests

##### Sorting Tests

* Run _'Bubble Sort'_ Test

  ```bash
  npm run test-bubblesort
  ```

  ```bash
  npm run test-bubblesort:watch
  ```

* Run _'Insertion Sort'_ Test

  ```bash
  npm run test-insertionsort
  ```

  ```bash
  npm run test-insertionsort:watch
  ```

* Run _'Selection Sort'_ Test

  ```bash
  npm run test-selectionsort
  ```

  ```bash
  npm run test-selectionsort:watch
  ```

* Run _'Shell Sort'_ Test

  ```bash
  npm run test-shellsort
  ```

  ```bash
  npm run test-shellsort:watch
  ```

* Run _'Merge Sort'_ Test

  ```bash
  npm run test-mergesort
  ```

  ```bash
  npm run test-mergesort:watch
  ```

* Run _'Quick Sort'_ Test

  ```bash
  npm run test-quicksort
  ```

  ```bash
  npm run test-quicksort:watch
  ```

#### Data Structure Tests

* Run _'Singly Linked List'_ Test

  ```bash
  npm run test-singly-linked-list
  ```

  ```bash
  npm run test-singly-linked-list:watch
  ```

* Run _'Doubly Linked List'_ Test

  ```bash
  npm run test-doubly-linked-list
  ```

  ```bash
  npm run test-doubly-linked-list:watch
  ```