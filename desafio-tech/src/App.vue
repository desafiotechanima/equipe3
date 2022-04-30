<template>
  <div id="app">
    <b-navbar toggleable="lg" type="dark" variant="dark">
      <b-navbar-brand href="#"><img src="../src/assets/logo/logo.png" style="width:40%;"></b-navbar-brand>

      <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>

      <b-collapse id="nav-collapse" is-nav>
        <b-navbar-nav>
          <b-nav-item to="/"><img src="../src/assets/icons/home.svg" alt="icon"> Home</b-nav-item>
          <b-nav-item to="/playlist"><img src="../src/assets/icons/play.svg" alt="icon"> Playlists</b-nav-item>
          <b-nav-item to="/perfil"><img src="../src/assets/icons/profile.svg" alt="icon"> Perfil</b-nav-item>
          <b-nav-item to="/config"><img src="../src/assets/icons/config.svg" alt="icon"> Configurações</b-nav-item>
        </b-navbar-nav>
      </b-collapse>
    </b-navbar>

    <router-view />
  </div>
</template>

<style></style>
