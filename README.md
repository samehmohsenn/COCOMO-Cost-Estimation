# COCOMO-Cost-Estimation
A software project cost estimation model (estimating both effort and time for development) based on lines of code (LOC), for both basic and intermediate models that use extra cost drivers for calculation of actual effort

#1.Introduction

Motivation: 
This project is driven by the rising complexity and unpredictability in software 
development endeavors. As software systems become more complex, accurately gauging 
the effort, cost, and duration of projects becomes increasingly difficult. This uncertainty 
frequently results in delays, exceeding budgets, and dissatisfaction among stakeholders. 
To tackle these issues, our team has undertaken this project to investigate the utilization 
of the COCOMO model specifically in C# Windows Forms App development. Through 
the adoption of COCOMO, our objective is to bolster our capacity to forecast project 
results, allocate resources efficiently, and refine our overall project management 
methodologies.

Why COCOMO: 
COCOMO, known as the Constructive Cost Model, is renowned in the software 
development field for its extensive research and wide acceptance. Its significance lies in its 
capability to offer dependable estimates of project effort and cost by considering various 
project factors. Utilizing COCOMO allows us to reduce the risks associated with 
inaccurate project planning and ensure better alignment of resources with project 
demands. Additionally, COCOMO provides various advantages such as assisting in 
project budgeting, facilitating decision-making, and enhancing communication among 
project stakeholders. Its robustness and flexibility make it an ideal option for fulfilling 
our project's estimation requirements within the C# Windows Forms App environment.

Objectives: 
Developing a functional COCOMO model application using C# Forms required the 
creation of a user interface enabling users to engage with the model and acquire cost 
estimates.
Investigating the functionalities of both the Basic and Intermediate COCOMO models 
was a key aspect of our project. By implementing both versions, our aim was to 
comprehend the variances in their methodologies and assess the influence of cost drivers 
in the Intermediate model.
Ensuring a user-friendly experience for interacting with the COCOMO model was 
paramount. Our goal was to design a clear and intuitive interface that would streamline 
the process of obtaining cost estimates, catering to users with diverse technical 
backgrounds

#2. Problem Statement
The aim of this project is to develop a software tool that facilitates the calculation of effort and 
development time estimates using the Constructive Cost Model (COCOMO). The software will 
be designed to receive input parameters from users, such as project type and size, and compute 
the effort and time required for software development based on COCOMO equations.

#3. Input Test Data and Output
The user will input data needed for effort and time calculations, and depending on the mode the 
system is using, inputs will be used and different outputs will be calculated.

Basic Mode
For example: user wants to calculate Effort and TDEV for a basic model providing the KLOC;
INPUT: 300 KLOC
OUTPUT: Effort = a*(KLOC)^b = 3379.46 (mode is embedded based on KLOC count)
 TDEV = c*(effort)^d = 33.66
 
Intermediate mode:
For example: user wants to calculate Actual Effort for an intermediate model providing the 
KLOC;
INPUT: 200 KLOC, 15 selections for the EAF factor
OUTPUT: Initial Effort = 1133
 TDEV = 29.3
 Actual Effort = Initial Effort * EAF = 1133 * 1 (if all are nominal)

#4. Conclusion:
For both software engineers and project managers, COCOMO is an applicable and useful tool at a time 
when effective project planning is essential to success. Its continued application and adaption in a 
variety of settings show how valuable it is in the always-changing field of software development. We 
effectively integrated both the Basic and Intermediate COCOMO models into a user-friendly C# Forms 
application. This endeavor yielded significant insights and achievements:
Enriched Understanding of COCOMO: We deepened our comprehension of the COCOMO model, 
encompassing its fundamental principles, mathematical formulations, and practical utilization for 
software cost estimation.
Strengthened C# Proficiency: The project served as a platform for honing our skills in C# 
programming. We particularly focused on refining our expertise in aspects such as interface design, 
data management, and computational operations.
For both software engineers and project managers, COCOMO is an applicable and useful tool at a time 
when effective project planning is essential to success. Its continued application and adaption in a 
variety of settings show how valuable it is in the always-changing field of software development.

#5. Refereneces: 
Campus Lectures and Labs
Code350Library
University of Oxford
GeeksforGeeks
ResearchGate
