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