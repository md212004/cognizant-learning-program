# React Fundamentals – Assignment Summary

This document outlines the theoretical concepts covered in our React learning journey, including SPA, React basics, components, lifecycle, and more.

---

## 1. What is SPA?

A **Single-Page Application (SPA)** is a web application that interacts with the user by dynamically rewriting the current page rather than loading entire new pages from the server.

### Benefits of SPA:
- Faster navigation (no full page reloads)
- Better user experience
- Efficient use of APIs via AJAX
- Seamless transitions between views

---

## 2. What is React?

**React** is a JavaScript library developed by Facebook for building fast and interactive user interfaces. It uses a declarative approach to describe UI components.

### How React Works:
- Uses a **virtual DOM** to optimize performance.
- React updates only the parts of the actual DOM that change.
- Promotes a component-based architecture for modular development.

---

## 3. SPA vs MPA

| Feature | SPA | MPA |
|--------|-----|-----|
| Page Load | Loads only once | Loads new HTML on each request |
| Performance | Faster after initial load | Slower due to full reloads |
| Backend Interaction | Uses AJAX/API | Directly loads HTML from backend |
| Routing | Client-side | Server-side |
| Examples | Gmail, Facebook | Amazon, Wikipedia |

---

## 4. Pros and Cons of SPA

### Pros:
- Smooth user experience
- Efficient resource usage
- Easy to debug with browser dev tools

### Cons:
- SEO limitations
- Initial load may be heavier
- Requires handling client-side routing

---

## 5. Virtual DOM

The **Virtual DOM** is a lightweight JavaScript representation of the real DOM. React uses it to:
- Track changes in state or props
- Re-render only the modified nodes
- Avoid direct manipulation of the DOM for performance

---

## 6. Features of React

- Declarative UI
- Component-Based Structure
- Virtual DOM for performance
- Unidirectional Data Flow
- JSX Syntax (HTML + JavaScript)
- Support for Hooks (in functional components)

---

## 7. React Components

React components are the building blocks of a UI. They are reusable and self-contained, managing their own structure and behavior.

### Types of Components:
- **Class Components**: ES6 classes, can manage state and lifecycle methods.
- **Function Components**: Plain JS functions, enhanced with Hooks to manage state and effects.

---

## 8. Components vs JavaScript Functions

| Feature | React Component | JavaScript Function |
|---------|------------------|---------------------|
| Purpose | UI rendering | Logic/calculations |
| Output | JSX (UI structure) | Return values |
| State | Can hold state | No concept of state |
| Lifecycle | Yes (in class components) | No |
| Hooks | Supported (in function components) | Not applicable |

---

## 9. Class Components

A class component is defined using ES6 `class` and extends `React.Component`. It must include a `render()` method.

### Example:
```jsx
class Greeting extends React.Component {
  render() {
    return <h1>Hello, {this.props.name}</h1>;
  }
}
