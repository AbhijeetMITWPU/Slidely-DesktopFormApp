import express, { Request, Response } from 'express';
import bodyParser from 'body-parser';
import * as path from 'path';
import { readFileSync, writeFileSync, existsSync } from 'fs';

const app = express();
const PORT = process.env.PORT || 5000;
const dbFilePath = path.join(__dirname, 'db.json');

// Ensure the db.json file exists with an empty array if not present
if (!existsSync(dbFilePath)) {
  writeFileSync(dbFilePath, '[]', 'utf8');
}

// Middleware
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));

// Interface for Submission object
interface Submission {
  id: number;
  name: string;
  email: string;
  phone: string;
  github_link: string;
  stopwatch_time: string;
}

// Routes

// Ping route for health check
app.get('/ping', (req: Request, res: Response) => {
  res.json({ success: true });
});

// POST route to handle submissions
app.post('/submit', (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;

  // Validate required fields
  if (!name || !email || !phone || !github_link || !stopwatch_time) {
    return res.status(400).json({ error: 'All fields are required' });
  }

  // Read current submissions from db.json
  const submissions: Submission[] = JSON.parse(readFileSync(dbFilePath, 'utf8'));

  // Generate new ID based on the last ID in the array
  const newId = submissions.length > 0 ? submissions[submissions.length - 1].id + 1 : 1;

  // Create new submission object with auto-incremented ID
  const newSubmission: Submission = {
    id: newId,
    name,
    email,
    phone,
    github_link,
    stopwatch_time
  };

  // Push new submission to submissions array
  submissions.push(newSubmission);

  // Write updated submissions back to db.json
  writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2), 'utf8');

  res.json({ success: true });
});

// GET route to read all submissions
app.get('/read', (req: Request, res: Response) => {
  // Read submissions from db.json
  const submissions: Submission[] = JSON.parse(readFileSync(dbFilePath, 'utf8'));
  res.json(submissions);
});

// DELETE route to delete a submission by ID
app.delete('/submission/:id', (req: Request, res: Response) => {
  const { id } = req.params;

  // Read current submissions from db.json
  let submissions: Submission[] = JSON.parse(readFileSync(dbFilePath, 'utf8'));

  // Find submission index by id
  const indexToDelete = submissions.findIndex((submission: Submission) => submission.id === parseInt(id));

  if (indexToDelete === -1) {
    return res.status(404).json({ error: 'Submission not found' });
  }

  // Remove submission from array
  submissions.splice(indexToDelete, 1);

  // Write updated submissions back to db.json
  writeFileSync(dbFilePath, JSON.stringify(submissions, null, 2), 'utf8');

  res.json({ success: true });
});

// Start server
app.listen(PORT, () => {
  console.log(`Server is running on http://localhost:${PORT}`);
});
