
# React Hands-on Labs – Comprehensive Guide

This document explains the theory and practical implementations behind a series of hands-on labs using React. Each section aligns with objectives from the assignments.

---

## Lab 1: Event Handling in React

### Objectives:
- Explain React events and event handlers
- Define synthetic events
- Understand React event naming conventions
- Use `this` keyword in event handlers

###  Key Concepts:

#### React Events
React wraps native DOM events with its own `SyntheticEvent` for cross-browser compatibility. These events are attached using camelCase:

```jsx
<button onClick={handleClick}>Click Me</button>
```

#### Event Handlers
Functions triggered in response to user interactions like clicks, typing, etc.

```jsx
const handleClick = () => {
  alert('Button was clicked!');
};
```

#### Synthetic Events
React's cross-browser wrapper around the browser's native event. Has the same interface as native events.

```jsx
const handleSyntheticEvent = (e) => {
  e.preventDefault();
  alert("This is a synthetic event.");
};
```

#### Using `this`
In class components, event handlers often require binding `this`:

```js
this.handleClick = this.handleClick.bind(this);
```

In functional components with hooks, `this` is not required.

---

## Lab 2: Currency Converter

### Objectives:
- Handle `onChange` and `onClick` events
- Create a reusable component
- Capture input values and process them on form submission

###  Key Concepts:

- Use `useState()` to store user input and computed values.
- Use `onSubmit` or `onClick` to handle conversion logic.

```jsx
<form onSubmit={handleSubmit}>
  <input type="number" onChange={handleChange} />
  <button type="submit">Convert</button>
</form>
```

---

## Lab 3: Conditional Rendering – Ticket Booking App

###  Objectives:
- Show different UI based on authentication
- Use conditionals (`if-else`, ternary, logical AND) in JSX

###  Key Concepts:

#### Element Variables
Assign components to variables and render them conditionally.

```jsx
let content;
if (isLoggedIn) {
  content = <UserPage />;
} else {
  content = <GuestPage />;
}
```

#### Prevent Rendering
Return `null` from a component to avoid rendering:

```jsx
if (!isVisible) return null;
```

---

## Lab 4: Conditional Rendering with Multiple Components

### 🔍 Objectives:
- Render different components (Book, Blog, Course) based on user choice
- Use `switch`, `if`, and ternary operators for conditional rendering

###  Key Concepts:

```jsx
const renderComponent = () => {
  switch (choice) {
    case 'book':
      return <BookDetails />;
    case 'blog':
      return <BlogDetails />;
    case 'course':
      return <CourseDetails />;
    default:
      return <p>Select a category</p>;
  }
};
```

---

## Lab 5: List Rendering and Keys in React

###  Objectives:
- Render multiple components using `.map()`
- Use unique keys for lists
- Extract repeated UI into components

###  Key Concepts:

#### map() Function

```jsx
const books = ["Book A", "Book B"];
books.map((book, index) => (
  <li key={index}>{book}</li>
));
```

#### Keys in Lists
- Help React identify which items changed, added or removed.
- Must be unique and stable.

#### Component Extraction

```jsx
const Book = ({ title }) => <li>{title}</li>;

books.map((book, index) => (
  <Book key={index} title={book} />
));
```

---

##  Prerequisites for All Labs

- Node.js and npm installed
- React project setup using `npx create-react-app`
- Visual Studio Code editor
- Basic understanding of JSX and React components

