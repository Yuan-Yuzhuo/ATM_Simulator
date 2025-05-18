# Computer System 2B Assignment 2 – ATM Simulator (Group 4)

**Author**: Qiying Huang, Yuhang Chen, Yuzhuo Yuan, Zeyi Wang  
**Module**: Computer System 2B  
**Deadline**: 29 May 2025, 12:00 PM  
**Group**: G4  
**IDE**: Visual Studio 2022 (.NET 8)  
**Language**: C#  
**Word Count (report)**: 587 words  

---

## 📌 Project Overview

This assignment implements a multi-threaded ATM simulation system to demonstrate and resolve concurrency issues such as **data races** during concurrent access to shared bank accounts. The GUI mimics real-world ATM functionality and allows switching between **data race** and **race-free** modes to clearly demonstrate the effect of improper synchronization.

The project is divided into multiple logical classes, each encapsulating clear responsibilities (e.g., `ATM`, `Account`, `CentralSystem`). The solution uses **threads**, **locks**, and **semaphores** to simulate and control concurrency access.

---

## 🧩 Key Features

- 🖥️ GUI interface using Windows Forms to mimic ATM panels  
- 🔁 Multi-threaded execution of multiple ATMs  
- ⚠️ Race Condition Simulation: intentionally created by removing synchronization  
- ✅ Race-Free Condition: enforced using `lock`, `Monitor`, or `SemaphoreSlim`  
- 🕹️ Step-by-step transaction flow for classroom demonstration  
- 🧠 Central system controls ATM access and account consistency  
- 🎯 Toggle switch in UI to demonstrate **data race** vs **non-race** modes

---

## 🚀 How to Run

1. Open `ATM_Simulator.sln` in Visual Studio 2022  
2. Build the solution  
3. Run the project  
4. In the GUI, you can:
   - Select **Data Race Mode** or **Synchronized Mode**
   - Launch multiple ATM windows
   - Log into same account concurrently and test withdraw behavior

---

## 🔄 Mode Demonstration

| Mode               | Description                                             |
|--------------------|---------------------------------------------------------|
| Data Race          | No locking, concurrent threads may corrupt balance      |
| Synchronized Mode  | Critical sections protected with `lock` or semaphore    |

> **Note**: You may add artificial delays (`Thread.Sleep`) to widen the race window.

---

## 🧵 Threading and Synchronization

- Each ATM runs in its own thread (`Task` or `Thread`)  
- Shared access to account is synchronized with:
  - `lock (accountLock)` or  
  - `SemaphoreSlim.Wait()` / `Release()`  

This ensures only one thread may write the balance at a time in safe mode.

---

## 🧠 AI Collaboration Note

Some design ideas were drafted with AI support (ChatGPT), particularly:
- Planning synchronization model
- Generating explanatory documentation
- Reviewing threading logic

Final code and logic were manually evaluated and implemented.

---