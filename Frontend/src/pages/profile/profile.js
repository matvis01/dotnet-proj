import React, { useContext, useState } from "react"
import styles from "./profile.module.css"
import NavBar from "../../components/NavBar"
import { UserContext } from "../../context/userContext"
import api, { addAuthToken } from "../../api/api"

export default function Profile(props) {
  const { user, setUser } = useContext(UserContext)

  const [userName, setUserName] = useState("")
  const [password, setPassword] = useState("")


  async function submit(e) {
    e.preventDefault()
    setUser((prev) => ({
      ...prev,
      username: userName,
      password: password,
    }))

    try {
      const res = await api.put(`Users/${user.userId}`, user, addAuthToken)
      console.log("res:", res)
    } catch (e) {
      console.log(e)
    }
  }

  return (
    <div className={styles.page}>
      <NavBar />
      <div className={styles.myForm}>
        <h1 className={styles.text}>User Profile</h1>
        <p className={styles.text}>Username: {user.username}</p>
        <p className={styles.text}>Email: {user.email}</p>
      </div>
    </div>
  )
}
