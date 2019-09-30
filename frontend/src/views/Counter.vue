<template>
	<div>
		<h1>Counter</h1>

		<p>This is a simple example of a Vue and Vuex component.</p>

		<p aria-live="polite">
			Current count:
			<strong>{{ currentCount }}</strong>
		</p>

		<button class="increment" @click="incrementCounter">Increment</button>
		<button class="decrement" @click="decrementCounter">Decrement</button>
	</div>
</template>

<script>
import store from "../store";

export default {
	name: "Counter",
	computed: {
		currentCount() {
			return store.state.count;
		}
	},
	methods: {
		incrementCounter() {
			return store.commit("increment");
		},
		decrementCounter() {
			return store.commit("decrement");
		}
	}
};
</script>

<style scoped>
button {
	cursor: pointer;
	border: none;
	color: white;
	padding: 15px 32px;
	text-align: center;
	text-decoration: none;
	display: inline-block;
	font-size: 16px;
}

.increment {
	background-color: #4caf50; /* Green */
}

.decrement {
	background-color: #f44336; /* Green */
}
</style>
