require './queue.rb'

q = Queue.new(4)
q.enqueue("Ben")
q.enqueue("Olivia")
q.enqueue("Reese")
q.enqueue("Puff")

puts "Peek: #{q.peek}"
puts "Dequeue: #{q.dequeue}"
puts "Peek again: #{q.peek}"

q.enqueue("Too")
q.enqueue("Many")