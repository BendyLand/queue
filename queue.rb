require './node.rb'

class Queue
    attr_reader :max_size
    attr_accessor :head, :tail, :size

    def initialize(max_size = nil)
        @head = nil
        @tail = nil
        @max_size = max_size
        @size = 0
    end

    def enqueue(value)
        if self.has_space()
            item_to_add = Node.new(value)
            puts "Adding #{item_to_add.value} to the queue!"
            if self.is_empty()
                @head = item_to_add
                @tail = item_to_add
            else
                @tail.next_node = item_to_add
                @tail = item_to_add
            end
            @size += 1
        else
            puts "Sorry, no more room!"
        end
    end

    def dequeue()
        if @size > 0
            item_to_remove = @head
            puts "#{item_to_remove.value} is served!"
            if @size == 1
                @head = nil
                @tail = nil
            else
                @head = @head.next_node
            end
            @size -= 1
            return item_to_remove.value
        else
            puts "The queue is totally empty!"
        end
    end

    def peek()
        if @size > 0
            return @head.value
        else
            puts "No orders waiting."
        end
    end

    def has_space()
        if @max_size == nil
            return true
        else
            return @max_size > @size
        end
    end

    def is_empty()
        @size == 0
    end
end