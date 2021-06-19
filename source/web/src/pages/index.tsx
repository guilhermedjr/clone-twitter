import Head from 'next/head'
import { useContext } from 'react'
import Main from '../presentation/components/Main'
import { MenuBar } from '../presentation/components/MenuBar'
import { SideBar } from '../presentation/components/SideBar'
import { PeepModal } from '../presentation/components/PeepModal'
import { Container, Wrapper } from '../presentation/styles/main'
import { PeepsContext } from '../logic/contexts/PeepsContext'
import { Login } from '../presentation/components/Login'

export default function Index() {
  return (
    <>
      <Head>
        <title>Peep - Entre ou cadastre-se</title>
      </Head>
      <body>
        <Container>
          <Login />
        </Container>
      </body>
    </>
  )
}
