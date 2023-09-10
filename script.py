from queue_ import Queue

q = Queue(4)
q.enqueue("Ben")
q.enqueue("Olivia")
q.enqueue("Reese")
q.enqueue("Puff")

print("Peek: " + q.peek())
print("Dequeue: " + q.dequeue())
print("Peek again: " + q.peek())
q.enqueue("Too")
q.enqueue("Many")
