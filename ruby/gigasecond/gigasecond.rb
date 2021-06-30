module Gigasecond
  GIGASECOND = 1_000_000_000
  def self.from(moment)
    moment + GIGASECOND
  end
end
