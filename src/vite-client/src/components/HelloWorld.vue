<!--Script allows you to use the composition API without defining a setup function, making the component code cleaner and more concise. -->
<script setup>
//ref: Creates a reactive reference for a primitive type
//reactive: Creates a reactive object for more complex types
import { ref, reactive } from 'vue'

//defining components props
defineProps({
  msg: String,
})
//Any changes to 'count' are reactive with use of ref
//Vue will automatically update the DOM whenever its value changes.
const count = ref(0)

//creating reactive object state with properties count and message
const state = reactive({
  count: 0,
  message: 'empty'
})
//API to make an HTTP request to ASP.NET
fetch('http://http://localhost:5105/test')
//method reads the response body to completion and returns a promise that resolves with a text string.
.then(res => res.text())
.then(t => state.message = t)
</script>

<template>
  <h1>{{ msg }}</h1>
  <h1>{{ state.message }}</h1>

  <div class="card">
    <button type="button" @click="count++">count is {{ count }}</button>
    <p>
      Edit
      <code>components/HelloWorld.vue</code> to test HMR
    </p>
  </div>

  <p>
    Check out
    <a href="https://vuejs.org/guide/quick-start.html#local" target="_blank"
      >create-vue</a
    >, the official Vue + Vite starter
  </p>
  <p>
    Install
    <a href="https://github.com/vuejs/language-tools" target="_blank">Volar</a>
    in your IDE for a better DX
  </p>
  <p class="read-the-docs">Click on the Vite and Vue logos to learn more</p>
</template>

<style scoped>
.read-the-docs {
  color: #888;
}
</style>
