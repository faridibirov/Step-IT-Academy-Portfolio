import { Link, Outlet, NavLink, useLoaderData, Form, redirect, useNavigate, useSubmit } from "react-router-dom";
import { useEffect, useState } from "react";
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

  const [filter, setFilter] = useState("all");

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
      <h1>Checklist App by Farid</h1>
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
            <button type="submit">Add</button>
          </Form>
        </div>
        <Form method="post">
            <div className="filter-buttons">
            <label>Show:</label>

              <button type="button" id="all" onClick={() => setFilter("all")} className={filter === "all" ? "active" : ""} >All</button>
              <button type="button" id="done" onClick={() => setFilter("done")} className={filter === "done" ? "active" : ""}>Done</button>
              <button type="button" id="reminded" onClick={() => setFilter("reminded")} className={filter === "reminded" ? "active" : ""}>Reminded</button>
            </div>
          </Form>
   <nav>
      {tasks.length ? (
        <ul>
          {tasks
            .filter((task) => {
              if (filter === "all") return true;
              if (filter === "done") return task.done;
              if (filter === "reminded") return !task.done;
              return false;
            })
            .map((task) => (
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
                    {task.done && <span>✅</span>}
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