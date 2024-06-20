
# Slidely-DesktopFormApp

# Watch the Video
[![Watch the video](https://img.youtube.com/vi/vVRWyiCwFwU/maxresdefault.jpg)](https://youtu.be/vVRWyiCwFwU)

## Overview

Slidely-DesktopFormApp is a Windows Desktop Application built with Visual Basic in Visual Studio. The application allows users to create and view submissions through a user-friendly interface. The backend server, developed using TypeScript and Express, handles the data storage and retrieval operations. This README provides a comprehensive guide on how to set up, run, and use both the frontend and backend components of the application.

## Table of Contents

1. [Features](#features)
2. [Setup and Installation](#setup-and-installation)
    - [Frontend (Desktop App)](#frontend-desktop-app)
    - [Backend (Express Server)](#backend-express-server)
3. [Usage](#usage)
    - [Creating a New Submission](#creating-a-new-submission)
    - [Viewing Submissions](#viewing-submissions)
4. [API Endpoints](#api-endpoints)
5. [Repository Links](#repository-links)

## Features

### Frontend (Desktop App)

- **View Submissions**: Browse through all submitted forms using "Previous" and "Next" buttons.
- **Create New Submission**: Submit new entries with fields for Name, Email, Phone Number, and GitHub repo link.
- **Stopwatch Functionality**: Includes a stopwatch that can be paused and resumed without resetting.
- **Keyboard Shortcuts**: Use keyboard shortcuts for quick actions (e.g., Ctrl + S to submit the form).

### Backend (Express Server)

- **Endpoints**:
  - `/ping`: A GET request that always returns True.
  - `/submit`: A POST request to save new submissions.
  - `/read`: A GET request to retrieve all submissions.
  - `/submission/:id`: A DELETE request to remove a submission by ID.
  - `/submission/:id`: A PUT request to update a submission by ID.
- **Data Storage**: Submissions are stored in a JSON file (`db.json`).

## Setup and Installation

### Frontend (Desktop App)

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/your-username/Slidely-DesktopFormApp.git
   cd Slidely-DesktopFormApp
   ```

2. **Open in Visual Studio**:
   - Open Visual Studio.
   - Load the solution file (`Slidely-DesktopFormApp.sln`).

3. **Build and Run**:
   - Build the project to ensure all dependencies are installed.
   - Run the application.

### Backend (Express Server)

1. **Clone the Repository**:
   ```sh
   git clone https://github.com/your-username/Slidely-BackendServer.git
   cd Slidely-BackendServer
   ```

2. **Install Dependencies**:
   ```sh
   npm install
   ```

3. **Run the Server**:
   ```sh
   npm start
   ```
   The server will run on `http://localhost:5000`.

## Usage

### Creating a New Submission

1. **Open the Desktop App**.
2. **Click "Create New Submission"**.
3. **Fill in the Details**:
   - Name
   - Email
   - Phone Number
   - GitHub Repo Link
4. **Use the Stopwatch**:
   - Click the button to start, pause, and resume the stopwatch.
5. **Submit the Form**:
   - Press the Submit button or use the keyboard shortcut (Ctrl + S).

### Viewing Submissions

1. **Open the Desktop App**.
2. **Click "View Submissions"**.
3. **Navigate Submissions**:
   - Use the "Previous" and "Next" buttons to browse through entries.

## API Endpoints

### /ping

- **Method**: GET
- **Description**: Health check endpoint.
- **Response**: 
  ```json
  { "success": true }
  ```

### /submit

- **Method**: POST
- **Description**: Submits a new form entry.
- **Request Body**:
  ```json
  {
    "name": "Abhijeet  Singh",
    "email": "abhi.doe@example.com",
    "phone": "123-456-7890",
    "github_link": "https://github.com/johndoe",
    "stopwatch_time": "00:02:00"
  }
  ```
- **Response**: 
  ```json
  {
    "success": true
  }
  ```

### /read

- **Method**: GET
- **Description**: Retrieves all form entries.
- **Response**:
  ```json
  [
    {
      "id": 1,
      "name": "Abhijeet Singh",
      "email": "abhi.doe@example.com",
      "phone": "123-456-7890",
      "github_link": "https://github.com/johndoe",
      "stopwatch_time": "00:02:00"
    }
  ]
  ```

### /submission/:id

- **Method**: DELETE
- **Description**: Deletes a form entry by ID.
- **Response**:
  ```json
  {
    "success": true
  }
  ```

### /submission/:id

- **Method**: PUT
- **Description**: Updates a form entry by ID.
- **Request Body**:
  ```json
  {
    "name": "Abhijeet Update",
    "email": "abhis.doe@example.com",
    "phone": "987-654-3210",
    "github_link": "https://github.com/janedoe",
    "stopwatch_time": "00:03:30"
  }
  ```
- **Response**:
  ```json
  {
    "success": true
  }
  ```

## Repository Links

- [Frontend Repository](https://github.com/AbhijeetMITWPU/Slidely-DesktopFormApp)
- [Backend Repository](https://github.com/AbhijeetMITWPU/Slidely-DesktopFormApp/tree/main/slidelybackend)

