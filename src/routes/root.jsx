import { Link, Outlet, NavLink, useLoaderData, Form, redirect, useNavigate, useSubmit } from "react-router-dom";
import { useEffect } from "react";
import { getTasks, createTask } from "../tasks";

export async function loader({ request }) {
  const url = new URL(request.url);
  const q = url.searchParams.get("q");
  const tasks = await getTasks(q);
  return { tasks, q };
}

export async function action() {
  const task = await createTask();
  return redirect(`/tasks/${task.id}/edit`);;
}

function Root() {

  const { tasks, q } = useLoaderData();
  const navigation = useNavigate();
  const submit = useSubmit();

  const searching =

    navigation.location &&

    new URLSearchParams(navigation.location.search).has(

      "q"

    );

  useEffect(() => {
    document.getElementById("q").value = q;
  }, [q]);

  return (
    <>
      <div id="sidebar">
        <div>
          <Form id="search-form" role="search">
            <input
              id="q"
              className={searching ? "loading" : ""}
              aria-label="Search tasks"
              placeholder="Search"
              type="search"
              name="q"
              defaultValue={q}
              onChange={(event) => {
                submit(event.currentTarget.form);
              }}
            />
            <div
              id="search-spinner"
              aria-hidden
              hidden={true}
            />
            <div
              className="sr-only"
              aria-live="polite"
            ></div>
          </Form>
          <Form method="post">
            <button type="submit">New</button>
          </Form>
        </div>
        <nav>
          {tasks.length ? (
            <ul>
              {tasks.map((task) => (
                <li key={task.id}>
                  <NavLink
                    to={`tasks/${task.id}`}
                    className={({ isActive, isPending }) =>
                      isActive
                        ? "active"
                        : isPending
                          ? "pending"
                          : ""
                    }
                  >
                    <Link to={`tasks/${task.id}`}>
                      {task.task ? (
                        <>
                          {task.task}
                        </>
                      ) : (
                        <i>No task name</i>
                      )}{" "}
                      {task.done && <span>☑</span>}
                    </Link>
                  </NavLink>
                </li>
              ))}
            </ul>
          ) : (
            <p>
              <i>No tasks</i>
            </p>
          )}
        </nav>
      </div>
      <div id="detail">
        <Outlet />
      </div>
    </>
  );
}


export default Root;