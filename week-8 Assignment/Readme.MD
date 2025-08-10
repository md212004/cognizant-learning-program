# Git Demo Project

This repository demonstrates basic Git operations including branch creation, switching, merging, and resolving merge conflicts.

## 📌 Project Steps

### 1. **Initialize Repository**
```bash
git init
```
Initializes a new Git repository in your current directory.

---

### 2. **Add README File**
```bash
echo "# Git Demo Project" > README.md
git add README.md
git commit -m "Initial commit with README"
```
Creates a README file, stages it, and commits it.

---

### 3. **Create and Switch to a New Branch**
```bash
git branch feature-branch
git checkout feature-branch
```
Or in a single step:
```bash
git checkout -b feature-branch
```
Creates a new branch named `feature-branch` and switches to it.

---

### 4. **Add a New File**
```bash
echo "Welcome to Git Demo" > welcome.txt
git add welcome.txt
git commit -m "Added welcome.txt"
```
Creates `welcome.txt`, stages, and commits it.

---

### 5. **Switch Back to Main Branch**
```bash
git checkout main
```
Switches to the `main` branch.

---

### 6. **Merge Branch into Main**
```bash
git merge feature-branch
```
Merges changes from `feature-branch` into `main`.

---

### 7. **Simulate Merge Conflict**
1. Edit the same line in a file in both branches.
2. Commit changes in both branches.
3. Merge one branch into another to cause a conflict.

---

### 8. **Resolve Merge Conflict**
1. Open the conflicted file.
2. Edit it to keep the desired changes.
3. Stage and commit the resolved file:
```bash
git add conflicted_file.txt
git commit -m "Resolved merge conflict"
```

---

### 9. **Push Changes to Remote**
```bash
git remote add origin <repository_url>
git branch -M main
git push -u origin main
```
Links local repository to a remote and pushes changes.

---

## 📂 Repository Structure
```
GitDemo/
├── README.md
└── welcome.txt
```

---

## 📖 Summary
This project demonstrates the following Git concepts:
- Initializing a repository
- Creating branches
- Switching branches
- Merging branches
- Resolving merge conflicts
- Pushing to a remote repository
