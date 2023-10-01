import { Form, useLoaderData, redirect, useNavigate } from "react-router-dom";
import { updateTask } from "../tasks";

export async function action({ request, params }) {
  const formData = await request.formData();
  const updates = Object.fromEntries(formData);
  await updateTask(params.taskId, updates);
  return redirect(`/tasks/${params.taskId}`);
}


export default function EditTask() {
  const { task } = useLoaderData();
  const navigate = useNavigate();


  return (
    <Form method="post" id="task-form">
      <p>
        <span>Task</span>
        <input
          placeholder="Task name"
          aria-label="Task name"
          type="text"
          name="task"
          defaultValue={task.task}
        />
       
      </p>
      <label>
        <span>Description</span>
        <textarea
          name="notes"
          defaultValue={task.notes}
          rows={6}
        />
      </label>
      <p>
        <button type="submit">Save</button>
        <button type="button" onClick={() => {
            navigate(-1);
          }}
        >Cancel</button>
      </p>
    </Form>
  );
}