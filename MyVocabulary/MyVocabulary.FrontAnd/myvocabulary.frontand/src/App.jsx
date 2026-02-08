//import { useState } from 'react'
import './App.css'

function App() {
  //const [count, setCount] = useState(0)

  return (
    <>
          <body className="body">
              <h1 className="header">Мой словарный запас.</h1>

              <aside className="aside">
                  <nav>
                      <h3 className="header">функции</h3>
                      <ul>
                          <li>
                              <a href="entry.html">записать новое слово</a>
                          </li>
                          <li>
                              <a href="search.html">найти слово</a>
                          </li>
                          <li>
                              <a href="exercise.html">задание для проверки</a>
                          </li>
                      </ul>

                  </nav>
              </aside>
              <main className="main">
                  <p>Приложение поможет запомнить, выученные тобой ранее, иностранные слова.
                      Ты можешь выполнить запись нового слова с его переводом,
                      можешь найти среди записаных слов нужное,
                      также можешь получать задание для проверки знаний. </p>
                  <article></article>
              </main>
              <footer></footer>

          </body>
    </>

  )
}

export default App
