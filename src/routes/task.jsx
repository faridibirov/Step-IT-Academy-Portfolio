import { Form, useLoaderData, useFetcher } from "react-router-dom";
import { getTask, updateTask } from "../tasks";

export async function action({ request, params }) {
  let formData = await request.formData();
  return updateTask(params.taskId, {
    done: formData.get("done") === "true",
  });
}

export async function loader({ params }) {
  const task = await getTask(params.taskId);
  return { task };
}

export default function Task() {
  const { task } = useLoaderData();

  return (
    <div id="task">

      <div>
        <h1>
          {task.task ? (
            <>
              {task.task}
            </>
          ) : (
            <i>No task name</i>
          )}{" "}
          <Done task={task} />
        </h1>
        {task.notes && <p>{task.notes}</p>}

        <div>
          <Form action="edit">
            <button type="submit">Edit</button>
          </Form>
          <Form
            method="post"
            action="destroy"
            onSubmit={(event) => {
              if (
                !window.confirm(
                  "Please confirm you want to delete this record."
                )
              ) {
                event.preventDefault();
              }
            }}
          >
            <button type="submit">Delete</button>
          </Form>
        </div>
      </div>
    </div>
  );
}

function Done({ task }) {
  const fetcher = useFetcher();

  // yes, this is a `let` for later
  let isDone = task.done;
  return (
    <fetcher.Form method="post">
      <button
        name="done"
        value={isDone ? "false" : "true"}
        aria-label={
            isDone
            ? "Remove from done"
            : "Add to done"
        }
      >
        {isDone ? "☑ " : "☐"}
      </button>
      </fetcher.Form>
  );
}